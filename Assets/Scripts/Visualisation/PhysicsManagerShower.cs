using UnityEngine;

namespace LoonyEngine {

    // This class is used to render the data of a PhysicsManager
    public class PhysicsManagerShower : MonoBehaviour {

        private enum ObjectColor {
            Greyscale,
            Layers,
            Static,
            Trigger
        }

        #region [MemberFields]

        [SerializeField]
        private ObjectColor m_objectColor;

        [SerializeField]
        private bool m_showBroad;

        [SerializeField]
        private bool m_showNear;

        [SerializeField]
        private bool m_showTrigger;

        [SerializeField]
        private bool m_showCollision;

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

                Color color = Color.black;

                switch (m_objectColor) {
                    case ObjectColor.Greyscale: {
                            float f = (1 / (rb.ID + 1) * 364.24f) + rb.ID * ((719.1532f + 35 * rb.ID) + 17.546f * rb.ID);
                            f /= 32;
                            f %= 1.0f;
                            f = 0.5f + (f / 2);
                            color = new Color(f, f, f, 1);
                        }
                        break;
                    case ObjectColor.Layers: {
                            switch (rb.ColliderData.LayerNumber) {
                                case 0:
                                    float f = (1 / (rb.ID + 1) * 364.24f) + rb.ID * ((719.1532f + 35 * rb.ID) + 17.546f * rb.ID);
                                    f /= 32;
                                    f %= 1.0f;
                                    f = 0.5f + (f / 2);
                                    color = new Color(f, f, f, 1);
                                    break;
                                case 1:
                                    color = Color.green;
                                    break;
                                case 2:
                                    color = Color.magenta;
                                    break;
                                case 3:
                                    color = Color.blue;
                                    break;
                                case 4:
                                    color = Color.cyan;
                                    break;
                                case 5:
                                    color = (Color.magenta + Color.black) / 2;
                                    break;
                                case 6:
                                    color = (Color.yellow + Color.red) / 2;
                                    break;
                            }
                            break;
                        }
                    case ObjectColor.Static: {
                        //TODO
                        break;
                    }
                    case ObjectColor.Trigger: {
                        if (rb.ColliderData.IsTrigger) {
                            color = (Color.blue + Color.white) / 2;
                        } else {
                            color = (Color.green + Color.white) / 2;
                        }
                        break;
                    }
                }
                Gizmos.color = color;

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
                        color = Color.red;
                        break;
                    case CheckState.NarrowCheck:
                        if (!m_showNear) {
                            continue;
                        }
                        color = Color.yellow;
                        break;
                    case CheckState.Trigger:
                        if (!m_showTrigger) {
                            continue;
                        }
                        color = Color.blue;
                        break;
                    case CheckState.Collision:
                        if (!m_showCollision) {
                            continue;
                        }
                        color = Color.green;
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