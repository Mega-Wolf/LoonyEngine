namespace LoonyEngine {

    public abstract class Executable : Component {

        #region [Constructors]
        
        public Executable(GameObject gameObject) : base(gameObject) {
            //TODO
        }

        #endregion

        public abstract void Init();

    }

}