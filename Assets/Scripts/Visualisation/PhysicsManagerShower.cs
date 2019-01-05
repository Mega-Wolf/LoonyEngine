using UnityEngine;

namespace LoonyEngine {

    // This class is used to render the data of a PhysicsManager
    public class PhysicsManagerShower : MonoBehaviour {

        #region [MemberFields]

        [SerializeField]
        private bool m_showNear;

        [SerializeField]
        private bool m_showBroad;

        #endregion

        #region [FinalVariables]

        IPhysicsManager f_physicsManager;

        #endregion

        #region [Init]

        public void Init(IPhysicsManager pm) {
            f_physicsManager = pm;
        }

        #endregion

        private void OnDrawGizmos() {
            if (Level.Instance == null) {
                return;
            }

            // TODO I kind of should render these for every one
            foreach (Rigidbody rb in ((StupidPhysicsManager)SuperPhysicsManager.Instance.PhysicsManagers[0]).Rigidbodies) {
                ICollider2D col = rb.ColliderData.Collider2D;

                float f = (1 / (rb.ID + 1) * 364.24f) + rb.ID * ((719.1532f + 35 * rb.ID) + 17.546f * rb.ID);
                f /= 32;
                f %= 1.0f;
                f = 0.5f + (f / 2);
                Gizmos.color = new Color(f, f, f, 1);

                switch (col) {
                    case AABB aabb: {
                            Gizmos.DrawCube(rb.GameObject.Transform.Position.Vector2, rb.GameObject.Transform.Scale * new Vector3(aabb.Right.Float - aabb.Left.Float, aabb.Top.Float - aabb.Bottom.Float, 1));
                            break;
                        }
                    case Circle circle: {
                            Gizmos.DrawSphere(rb.GameObject.Transform.Position.Vector2, rb.GameObject.Transform.Scale * circle.Radius.Float);
                            break;
                        }
                }
            }

            // TODO This should also be done for everyone; not sure how to do that yet

            foreach (ulong id in ((AbstractPhysicsManager)SuperPhysicsManager.Instance.PhysicsManagers[0]).CheckStates.Keys) {
                CheckState cs = ((AbstractPhysicsManager)SuperPhysicsManager.Instance.PhysicsManagers[0]).CheckStates[id];

                uint id1 = (uint)(id >> 32);
                uint id2 = (uint)id;

                Color color = Color.blue;

                switch (cs) {
                    case CheckState.BroadCheck:
                        if (!m_showBroad) {
                            continue;
                        }
                        color = Color.yellow;
                        break;
                    case CheckState.NarrowCheck:
                        if (!m_showNear) {
                            continue;
                        }
                        color = (Color.yellow + Color.red) / 2;
                        break;
                }
                Gizmos.color = color;
                Gizmos.DrawLine(Rigidbody.GetRigidbody(id1).GameObject.Transform.Position.Vector2, Rigidbody.GetRigidbody(id2).GameObject.Transform.Position.Vector2);
            }

        }

        private void OnDrawGizmosSelected() {

        }

    }

}