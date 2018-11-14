namespace LoonyEngine {

    public abstract class Executable : Component {

        #region [PrivateVariables]

        private bool m_enabled;

        #endregion

        #region [Properties]

        public bool Enabled {
            get {
                return Enabled;
            }
            set {
                //TODO
                // put to update loop etc.
            }
        }

        #endregion

        #region [Constructors]
        
        public Executable(GameObject gameObject) : base(gameObject) {
            //TODO
        }

        #endregion

        #region [Init]

        public abstract void Init();

        #endregion

        #region [Updates]

        public abstract void RenderUpdate();
        public abstract void FixedUpdate();

        #endregion

    }

}