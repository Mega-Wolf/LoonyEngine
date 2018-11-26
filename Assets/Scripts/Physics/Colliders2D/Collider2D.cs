namespace LoonyEngine {

    public abstract class Collider2D : Component {

        #region [PrivateVariables]

        private bool m_isActive;

        private bool m_isTrigger;

        //TODO Rigidbody; physicsmaterial etc.

        #endregion

        #region [Constructors]

        public Collider2D(GameObject gameObject) : base(gameObject) {}

        #endregion

        #region [PublicMethods]

        public void AddToPhysics() {
            if (m_isActive) {
                return;
            }

            PhysicsManager.Instance.AddPhysicsComponent(this);

            m_isActive = true;
        }

        public void RemoveFromPhysics() {
            if (!m_isActive) {
                return;
            }

            PhysicsManager.Instance.RemovePhysicsComponent(this);

            m_isActive = false;
        }

        #endregion

    }
}