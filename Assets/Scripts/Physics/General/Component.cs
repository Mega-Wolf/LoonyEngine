namespace LoonyEngine {

    public abstract class Component {

        #region [Static]

        // TODO; theoretically this number could exceed the limits
        // It also is shared by all components and not component specific -.-
        // I would definitely do that different, with components beeing located in differeent list per component and then refilling gaps
        // For now, I at least could provide a dictionary
        static uint s_idCount = 0;

        #endregion

        #region [FinalVariables]

        protected uint f_id;

        #endregion

        #region [PrivateVariables]

        protected GameObject m_gameObject;

        #endregion

        #region [Properties]

        public uint ID { get { return f_id; } }
        public GameObject GameObject { get { return m_gameObject; } }

        #endregion

        #region [Constructors]

        public Component(GameObject gameObject) {
            m_gameObject = gameObject;

            f_id = s_idCount;
            ++s_idCount;
        }

        #endregion

    }

}