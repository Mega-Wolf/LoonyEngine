using UnityEngine;

namespace LoonyEngine {

    // This class is used to render the data of a PhysicsManager
    public class PhysicsManagerShower : MonoBehaviour {

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

            foreach (Rigidbody rb in Level.Instance.Rigidbodies) {
                ICollider2D col = rb.ColliderData.Collider2D;
                switch (col) {
                    case AABB aabb: {
                        float f = (1 / (rb.ID + 1) * 364.24f) + rb.ID * ((719.1532f + 35 * rb.ID) + 17.546f * rb.ID);
                        f /= 32;
                        f %= 1.0f;

                        f = 0.5f + (f / 2);
                        Gizmos.color = new Color(f, f, f, 1);
                        //DebugExtension.DrawLocalCube(this.transform, new Vector3(aabb.Right.Float - aabb.Left.Float, aabb.Top.Float - aabb.Bottom.Float , 1), Color.black, rb.GameObject.Transform.Position.Vector2);

                        Gizmos.DrawCube(rb.GameObject.Transform.Position.Vector2, rb.GameObject.Transform.Scale * new Vector3(aabb.Right.Float - aabb.Left.Float, aabb.Top.Float - aabb.Bottom.Float , 1));
                        break;
                    }
                    case Circle circle: {
                        Gizmos.DrawSphere(rb.GameObject.Transform.Position.Vector2, rb.GameObject.Transform.Scale * circle.Radius.Float);
                        break;
                    }
                }
            }
        }

        private void OnDrawGizmosSelected() {

        }

    }

}