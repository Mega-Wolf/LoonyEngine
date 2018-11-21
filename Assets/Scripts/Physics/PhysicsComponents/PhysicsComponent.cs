namespace LoonyEngine {

    public class PhysicsComponent : Component {

        #region [PrivateVariables]

        private bool m_isActive;

        private bool m_isTrigger;
        //TODO Rigidbody; physicsmaterial etc.

        #endregion

        #region [Constructors]

        public PhysicsComponent(GameObject gameObject) : base(gameObject) {
            //TODO
        }

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