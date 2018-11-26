namespace LoonyEngine {

    public class RectangleCollider2D : Collider2D {

        #region [PrivateVariables]

        public Rectangle m_rectangle;

        #endregion

        #region [Properties]

        public Rectangle Rectangle {
            get {
                return m_rectangle;
            }
            set {
                m_rectangle = value;
                // TODO; update the values in PhysicsManager
            }
        }

        #endregion

        #region [Constructors]

        public RectangleCollider2D(GameObject gameObject) : base(gameObject) {}

        #endregion

    }
    
}