#if UNITY_EDITOR
using UnityEditor;
#endif

using System.Collections.Generic;
using UnityEngine;

namespace LoonyEngine {

    public enum CheckState {
        BroadCheck,
        NarrowCheck,
        Trigger,
        Collision
    }

    // This is kind of stupid, but this is the easiest way to track the data for the different PMs
    public abstract class AbstractPhysicsManager : IPhysicsManager {

        #region [Static]

        public static ulong CalcRBID(Rigidbody rb1, Rigidbody rb2) {
            if (rb1.ID < rb2.ID) {
                return ((ulong)rb1.ID << 32) + rb2.ID;
            } else {
                return ((ulong)rb1.ID << 32) + rb2.ID;
            }
        }

        #endregion

        #region [PrivateVariables]

        private HashSet<ulong> f_collisionsLastRound = new HashSet<ulong>();
        private HashSet<ulong> f_collisionsThisRound = new HashSet<ulong>();

        private Dictionary<ulong, CheckState> f_checkStates = new Dictionary<ulong, CheckState>();

        private int m_broadChecks = 0;
        private int m_narrowChecks = 0;
        private int m_triggers = 0;
        private int m_collisions = 0;

        protected List<ObjectOrderInformation> f_oois = new List<ObjectOrderInformation>();

        protected PhysicsMatrix f_physicsMatrix;

        #endregion

        #region [Properties]

        public Dictionary<ulong, CheckState> CheckStates { get { return f_checkStates; } }

        #endregion

        #region [PublicMethods]

        public void SetPhysicsMatrix(PhysicsMatrix physicsMatrix) {
            f_physicsMatrix = physicsMatrix;
        }

        public virtual void Simulate() {
            f_checkStates.Clear();
            m_broadChecks = 0;
            m_narrowChecks = 0;
            m_triggers = 0;
            m_collisions = 0;
        }

        #endregion

        #region [PrivateMethods]

        protected bool BroadPhase(Rigidbody rb1, Rigidbody rb2) {
            // TODO this got taken out because it was too expensive for StupidPM
            // I have to be able to use it though for later PMs
            //f_checkStates[CalcRBID(rb1, rb2)] = CheckState.BroadCheck;

            ++m_broadChecks;

            return
            f_physicsMatrix.DoCollide(rb1.ColliderData.LayerNumber, rb2.ColliderData.LayerNumber) &&
            Intersections.DoIntersectAABBAABB(rb1.ColliderData.GlobalAABB, rb2.ColliderData.GlobalAABB);
        }

        protected void NarrowPhase(Rigidbody rb1, Rigidbody rb2) {
            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.NarrowCheck;
            ++m_narrowChecks;

            // TODO colelct this data
            // TODO: I have to know if this collision is new or not

            // If none of them are triggers, that means that the collision shall be resolved
            if (!rb1.ColliderData.IsTrigger && !rb2.ColliderData.IsTrigger) {
                //TODO; check directly for collision + resolve if possible (resolve only if moving towards each other)

                if (rb1.ColliderData.Collider2D is AABB) {
                    if (rb2.ColliderData.Collider2D is AABB) {
                        // this should not be possible is this example
                    } else {
                        // AABB - Circle
                    }
                } else {
                    if (rb2.ColliderData.Collider2D is AABB) {
                        // Circle - AABB
                    } else {
                        // Circle - Circle
                    }
                }

                // pass collision to the event
            } else { // this means not both are colliders, so I only fire a trigger event on both (if touching)
                // In a trigger, we only care, whether they are touching or not
                if (rb1.ColliderData.Collider2D is AABB) {
                    if (rb2.ColliderData.Collider2D is AABB) {
                        // this should not be possible in this example
                        if (Intersections.DoIntersectAABBAABB((AABB)rb1.ColliderData.Collider2D, (AABB)rb2.ColliderData.Collider2D, rb1.GameObject.Transform, rb2.GameObject.Transform)) {
                            // call triggers for 1 and send 2
                            // call triggers for 2 and send 1
                            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.Trigger;
                            ++m_triggers;
                        }
                    } else {
                        // AABB - Circle
                        if (Intersections.DoIntersectAABBCircle((AABB)rb1.ColliderData.Collider2D, (Circle)rb2.ColliderData.Collider2D, rb1.GameObject.Transform, rb2.GameObject.Transform)) {
                            // call triggers for 1 and send 2
                            // call triggers for 2 and send 1
                            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.Trigger;
                            ++m_triggers;
                        }

                    }
                } else {
                    if (rb2.ColliderData.Collider2D is AABB) {
                        // Circle - AABB
                        if (Intersections.DoIntersectAABBCircle((AABB)rb2.ColliderData.Collider2D, (Circle)rb1.ColliderData.Collider2D, rb2.GameObject.Transform, rb1.GameObject.Transform)) {
                            // call triggers for 1 and send 2
                            // call triggers for 2 and send 1
                            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.Trigger;
                            ++m_triggers;
                        }
                    } else {
                        // Circle - Circle
                        if (Intersections.DoIntersectCircleCircle((Circle)rb1.ColliderData.Collider2D, (Circle)rb2.ColliderData.Collider2D, rb1.GameObject.Transform, rb2.GameObject.Transform)) {
                            // call triggers for 1 and send 2
                            // call triggers for 2 and send 1
                            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.Trigger;
                            ++m_triggers;
                        }
                    }
                }

                // TODO only check if they are touching + calling trigger functions after that if any
                // pass collider to the event
            }

        }

        #endregion

        #region [Abstracts]

        public abstract void AddPhysicsComponent(Rigidbody rb);
        public abstract void RemovePhysicsComponent(Rigidbody rb);

        #endregion

        #region [GUI]

#if UNITY_EDITOR

        public virtual void Render() {
            EditorGUILayout.LabelField("Broad checks:", m_broadChecks + "");
            EditorGUILayout.LabelField("Narrow checks:", m_narrowChecks + "");
            EditorGUILayout.LabelField("Triggers:", m_triggers + "");
            EditorGUILayout.LabelField("Collisions:", m_collisions + "");

            for (int i = 0; i < f_oois.Count; ++i) {
                GUILayout.BeginArea(new Rect(0, 4 * 18 + 10 + 45 * i, 1000, 45));
                f_oois[i].Render();
                GUILayout.EndArea();
            }
        }

        public virtual void UpdateRenderData() {
            foreach (ObjectOrderInformation ooi in f_oois) {
                ooi.UpdateIDs();
            }
        }

#endif

        #endregion
    }

}