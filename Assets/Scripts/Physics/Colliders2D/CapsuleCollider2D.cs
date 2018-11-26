namespace LoonyEngine {

    public class CapsuleCollider2D : Collider2D {

        #region [PrivateVariables]

        private Capsule m_capsule;

        #endregion

        #region [Properties]

        public Capsule Capsule {
            get {
                return m_capsule;
            }
            set {
                m_capsule = value;
                // TODO; update the values in PhysicsManager
            }
        }

        #endregion

        #region [Constructors]

        public CapsuleCollider2D(GameObject gameObject) : base(gameObject) {}

        #endregion
    }
    
}