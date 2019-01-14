#define DEBUG_COLLISIONS

#if UNITY_EDITOR
using UnityEditor;
#endif

using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;

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

        #region [FinalVariables]

        protected PhysicsMatrix f_physicsMatrix;

        private Dictionary<ulong, CheckState> f_checkStates = new Dictionary<ulong, CheckState>();

        protected List<ObjectOrderInformation> f_oois = new List<ObjectOrderInformation>();

        #endregion

        #region [PrivateVariables]

        protected int m_moved = 0;
        private int m_broadChecks = 0;
        private int m_narrowChecks = 0;
        private int m_triggers = 0;
        private int m_collisions = 0;

        protected TimeSpan m_movementTime;
        protected TimeSpan m_collisionTime;

        protected Dictionary<ulong, CollisionDataRB> m_collisionsLastFrame = new Dictionary<ulong, CollisionDataRB>();
        protected Dictionary<ulong, CollisionDataRB> m_collisionsThisFrame = new Dictionary<ulong, CollisionDataRB>();

        protected HashSet<ulong> m_triggersLastFrame = new HashSet<ulong>();
        protected HashSet<ulong> m_triggersThisFrame = new HashSet<ulong>();

        protected Stopwatch f_stopwatch = new Stopwatch();

        #endregion

        #region [Properties]

        public Dictionary<ulong, CheckState> CheckStates { get { return f_checkStates; } }

        public abstract IEnumerable<Rigidbody> Rigidbodies { get; }

        public abstract string Name { get; }

        #endregion

        #region [PublicMethods]

        public virtual void SetPhysicsMatrix(PhysicsMatrix physicsMatrix) {
            f_physicsMatrix = physicsMatrix;
        }

        public virtual void Simulate() {

            /* Resetting print data */
            {
                m_moved = 0;
#if DEBUG_COLLISIONS
                f_checkStates.Clear();
                m_broadChecks = 0;
                m_narrowChecks = 0;
                m_triggers = 0;
                m_collisions = 0;
#endif
            }

            /* Resetting the trigger and collider data */
            {
#if DEBUG_COLLISIONS
                HashSet<ulong> dummyTriggers = m_triggersLastFrame;
                m_triggersLastFrame = m_triggersThisFrame;
                m_triggersThisFrame = dummyTriggers;
                m_triggersThisFrame.Clear();
                Dictionary<ulong, CollisionDataRB> dummyCollisions = m_collisionsLastFrame;
                m_collisionsLastFrame = m_collisionsThisFrame;
                m_collisionsThisFrame = dummyCollisions;
                m_collisionsThisFrame.Clear();
#endif
            }

        }

        #endregion

        #region [PrivateMethods]

        protected bool BroadPhase(Rigidbody rb1, Rigidbody rb2, bool recordAllData = false) {

#if DEBUG_COLLISIONS
            if (recordAllData || (ulong)rb1.ID < 3 || (ulong)rb2.ID < 3) {
                f_checkStates[CalcRBID(rb1, rb2)] = CheckState.BroadCheck;
            }
            ++m_broadChecks;
#endif

            return
            f_physicsMatrix.DoCollide(rb1.ColliderData.LayerNumber, rb2.ColliderData.LayerNumber) &&
            Intersections.DoIntersectAABBAABB(rb1.ColliderData.GlobalAABB, rb2.ColliderData.GlobalAABB);
        }

        protected void NarrowPhase(Rigidbody rb1, Rigidbody rb2) {
#if DEBUG_COLLISIONS
            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.NarrowCheck;
            ++m_narrowChecks;
#endif

            // If none of them are triggers, that means that the collision shall be resolved
            // Well, they cannot be resolved here already; the data has to be remembered until the end of the resolutions
            if (!rb1.ColliderData.IsTrigger && !rb2.ColliderData.IsTrigger) {
                // TODO; Implement the other collisions

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
                        CollisionDataRB cd = Intersections.CollisionCircleCircle((Circle)rb1.ColliderData.Collider2D, (Circle)rb2.ColliderData.Collider2D, rb1, rb2);
                        if (cd.DidCollide) {
                            //UnityEngine.Debug.Log(Name + ": " + (rb1.ID / 4) + " - " + (rb2.ID / 4));
                            m_collisionsThisFrame[CalcRBID(rb1, rb2)] = cd;
                            m_collisionsLastFrame.Remove(CalcRBID(rb1, rb2));
#if DEBUG_COLLISIONS
                            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.Collision;
                            ++m_collisions;
#endif

                            //TESTING
                            // this is so bad, that I only keep it here, to not think it would be nice
                            // As stated above, THIS SHOULD NOT HAPPEN HERE!!!!!
                            // Also, this now triggers a collision although the collision is considered as not happening
                            Velocity v1 = rb1.DynamicData.Velocity;
                            Velocity v2 = rb2.DynamicData.Velocity;

                            //if (Velocity.Angle(v1, v2) < new Angle(90)) {
                            if (!m_collisionsLastFrame.ContainsKey(CalcRBID(rb1, rb2))) {
                                Mass m1 = rb1.ObjectData.Mass;
                                Mass m2 = rb2.ObjectData.Mass;

                                rb1.DynamicData = new DynamicData((v1 * (m1 - m2) + (2 * m2 * v2)) / (m1 + m2), Acceleration.zero);
                                rb2.DynamicData = new DynamicData((v2 * (m2 - m1) + (2 * m1 * v1)) / (m2 + m1), Acceleration.zero);
                            }
                            //TESTING END
                        }

                    }
                }

                // pass collision to the event
            } else { // this means not both are colliders, so I only fire a trigger event on both (if touching)
                // In a trigger, we only care, whether they are touching or not
                // TODO I can already call the trigger functions here

                if (rb1.ColliderData.Collider2D is AABB) {
                    if (rb2.ColliderData.Collider2D is AABB) {
                        // this should not be possible in this example
                        if (Intersections.DoIntersectAABBAABB((AABB)rb1.ColliderData.Collider2D, (AABB)rb2.ColliderData.Collider2D, rb1.GameObject.Transform, rb2.GameObject.Transform)) {
                            // call triggers for 1 and send 2
                            // call triggers for 2 and send 1

                            m_triggersThisFrame.Add(CalcRBID(rb1, rb2));
                            m_triggersLastFrame.Remove(CalcRBID(rb1, rb2));
#if DEBUG_COLLISIONS
                            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.Trigger;
                            ++m_triggers;
#endif
                        }
                    } else {
                        // AABB - Circle
                        if (Intersections.DoIntersectAABBCircle((AABB)rb1.ColliderData.Collider2D, (Circle)rb2.ColliderData.Collider2D, rb1.GameObject.Transform, rb2.GameObject.Transform)) {
                            // call triggers for 1 and send 2
                            // call triggers for 2 and send 1

                            m_triggersThisFrame.Add(CalcRBID(rb1, rb2));
                            m_triggersLastFrame.Remove(CalcRBID(rb1, rb2));
#if DEBUG_COLLISIONS
                            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.Trigger;
                            ++m_triggers;
#endif
                        }

                    }
                } else {
                    if (rb2.ColliderData.Collider2D is AABB) {
                        // Circle - AABB
                        if (Intersections.DoIntersectAABBCircle((AABB)rb2.ColliderData.Collider2D, (Circle)rb1.ColliderData.Collider2D, rb2.GameObject.Transform, rb1.GameObject.Transform)) {
                            // call triggers for 1 and send 2
                            // call triggers for 2 and send 1
                            m_triggersThisFrame.Add(CalcRBID(rb1, rb2));
                            m_triggersLastFrame.Remove(CalcRBID(rb1, rb2));
#if DEBUG_COLLISIONS
                            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.Trigger;
                            ++m_triggers;
#endif
                        }
                    } else {
                        // Circle - Circle
                        if (Intersections.DoIntersectCircleCircle((Circle)rb1.ColliderData.Collider2D, (Circle)rb2.ColliderData.Collider2D, rb1.GameObject.Transform, rb2.GameObject.Transform)) {
                            // call triggers for 1 and send 2
                            // call triggers for 2 and send 1
                            m_triggersThisFrame.Add(CalcRBID(rb1, rb2));
                            m_triggersLastFrame.Remove(CalcRBID(rb1, rb2));
#if DEBUG_COLLISIONS
                            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.Trigger;
                            ++m_triggers;
#endif
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
        public abstract void ChangeLayer(Rigidbody rb, int oldLayerNumber, int newLayerNumber);

        #endregion

        #region [GUI]

#if UNITY_EDITOR

        public virtual void Draw(Vector2 offset) { }

        public virtual void Render() {
            /* Render Labels */
            {
                EditorGUILayout.LabelField("Name:", Name);
                EditorGUILayout.LabelField("Moved:", m_moved + "");
                EditorGUILayout.LabelField("Broad checks:", m_broadChecks + "");
                EditorGUILayout.LabelField("Narrow checks:", m_narrowChecks + "");
                EditorGUILayout.LabelField("Triggers:", m_triggers + "");
                EditorGUILayout.LabelField("Collisions:", m_collisions + "");
                EditorGUILayout.LabelField("Movement time:", m_movementTime.TotalMilliseconds + "");
                EditorGUILayout.LabelField("Collision time:", m_collisionTime.TotalMilliseconds + "");
            }

            /* Render OOIs */
            {
                for (int i = 0; i < f_oois.Count; ++i) {
                    Rect rect = EditorGUILayout.BeginVertical(GUILayout.MinHeight(18 + 25));
                    f_oois[i].Render(rect);
                    EditorGUILayout.EndVertical();
                }
            }
        }

        public virtual void UpdateRenderData() {
#if DEBUG_COLLISIONS
            foreach (ObjectOrderInformation ooi in f_oois) {
                ooi.UpdateIDs();
            }
#endif
        }

#endif

        #endregion
    }

}