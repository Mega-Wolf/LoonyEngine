namespace LoonyEngine {

    public abstract class Component {

        #region [PrivateVariables]

        protected GameObject m_gameObject;

        #endregion

        #region [Properties]

        public GameObject GameObject { get { return m_gameObject; } }

        #endregion

        #region [Constructors]

        public Component(GameObject gameObject) {
            m_gameObject = gameObject;
        }

        #endregion

    }

}