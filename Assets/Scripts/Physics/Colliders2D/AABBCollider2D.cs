namespace LoonyEngine {

    public class AABBCollider2D : PhysicsComponent {

        #region [PrivateVariables]

        private AABB m_aabb;

        #endregion

        #region [Properties]

        public AABB AABB {
            get {
                return m_aabb;
            }
            set {
                m_aabb = value;
                // TODO; update the values in PhysicsManager
            }
        }

        #endregion

        #region [Constructors]

        public AABBCollider2D(GameObject gameObject) : base(gameObject) {}

        #endregion
    }
    
}