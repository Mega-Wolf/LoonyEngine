namespace LoonyEngine {

    public class PhysicsComponent : Component {

        #region [PrivateVariables]

        private bool m_isTrigger;
        //TODO Rigidbody; physicsmaterial etc.

        private Position m_offset;

        #endregion

        #region [Constructors]

        public PhysicsComponent(GameObject gameObject) : base(gameObject) {
            //TODO
        }

        #endregion

    }
}