using System.Collections.Generic;

namespace LoonyEngine {

    public class GameObject {

        #region [FinalVariables]

        private readonly List<Component> f_components;
        private readonly Transform2D f_transform;

        #endregion

        #region [PrivateVariables]

        private string m_name;

        #endregion

        #region [Properties]

        public Transform2D Transform { get; }

        #endregion

        #region [Constructors]

        public GameObject(Transform2D transform2D) {
            f_transform = transform2D;
            f_components = new List<Component>();
        }

        #endregion

        #region [PublicMethods]

        // TODO
        //get components

        #endregion
    }

}