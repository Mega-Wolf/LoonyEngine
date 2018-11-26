namespace LoonyEngine {

    public class CircleCollider2D : Collider2D {

        #region [PrivateVariables]

        private Circle m_circle;

        #endregion

        #region [Properties]

        public Circle Circle {
            get {
                return m_circle;
            }
            set {
                m_circle = value;
                // TODO; update the values in PhysicsManager
            }
        }

        #endregion

        #region [Constructors]

        public CircleCollider2D(GameObject gameObject) : base(gameObject) {}

        #endregion

    }
    
}