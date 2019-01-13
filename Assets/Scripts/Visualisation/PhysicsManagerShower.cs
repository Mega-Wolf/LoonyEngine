using UnityEngine;

namespace LoonyEngine {

    /// This class is used to render the data of a PhysicsManager
    public class PhysicsManagerShower : MonoBehaviour {

        private enum ObjectColor {
            Greyscale,
            Layers,
            Static,
            Trigger
        }

        #region [MemberFields]

        [SerializeField]
        private Vector2 m_offset = new Vector2(300, 200);

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

            for (int apmCount = 0; apmCount < SuperPhysicsManager.Instance.PhysicsManagers.Count; ++apmCount) {

                Vector2Int offsetTiles = new Vector2Int(
                    apmCount % SuperPhysicsManager.Instance.PhysicsManagers.Count,
                    apmCount / SuperPhysicsManager.Instance.PhysicsManagers.Count
                );

                Vector2 offset = offsetTiles * m_offset;

                int rbCount = -1;
                foreach (Rigidbody rb in SuperPhysicsManager.Instance.PhysicsManagers[apmCount].Rigidbodies) {
                    ++rbCount;

                    ICollider2D col = rb.ColliderData.Collider2D;

                    Color color = Color.black;

                    switch (m_objectColor) {
                        case ObjectColor.Greyscale: {
                                //float f = (1 / (rb.ID + 1) * 364.24f) + rb.ID * ((719.1532f + 35 * rb.ID) + 17.546f * rb.ID);
                                float f = (1 / (rbCount + 1) * 364.24f) + rbCount * ((719.1532f + 35 * rbCount) + 17.546f * rbCount);
                                f /= 32;
                                f %= 1.0f;
                                f = 0.5f + (f / 2);
                                color = new Color(f, f, f, 1);
                            }
                            break;
                        case ObjectColor.Layers: {
                                switch (rb.ColliderData.LayerNumber) {
                                    case 0:
                                        float f = (1 / (rbCount + 1) * 364.24f) + rbCount * ((719.1532f + 35 * rbCount) + 17.546f * rbCount);
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
                                Gizmos.DrawCube(rb.GameObject.Transform.Position.Vector2 + offset, rb.GameObject.Transform.Scale * new Vector3(aabb.Right.Float - aabb.Left.Float, aabb.Top.Float - aabb.Bottom.Float, 1));
                                break;
                            }
                        case Circle circle: {
                                Gizmos.DrawSphere(rb.GameObject.Transform.Position.Vector2 + offset, rb.GameObject.Transform.Scale * circle.Radius.Float);
                                break;
                            }
                    }
                }

                foreach (ulong id in (SuperPhysicsManager.Instance.PhysicsManagers[apmCount]).CheckStates.Keys) {
                    CheckState cs = (SuperPhysicsManager.Instance.PhysicsManagers[apmCount]).CheckStates[id];

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
                    Gizmos.DrawLine(Rigidbody.GetRigidbody(id1).GameObject.Transform.Position.Vector2 + offset, Rigidbody.GetRigidbody(id2).GameObject.Transform.Position.Vector2 + offset);
                }

                SuperPhysicsManager.Instance.PhysicsManagers[apmCount].Draw(offset);

            }

        }

    }

}