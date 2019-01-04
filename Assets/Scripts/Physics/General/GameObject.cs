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

        public Transform2D Transform { get { return f_transform; } }

        #endregion

        #region [Constructors]

        public GameObject(Transform2D transform2D) {
            f_transform = transform2D;
            f_components = new List<Component>();
        }

        #endregion

        #region [PublicMethods]

        public GameObject CloneLeave() {
            Transform2D newTransform = new Transform2D(null);
            newTransform.Position = Transform.Position;
            newTransform.Angle = Transform.Angle;
            newTransform.Scale = Transform.Scale;
            GameObject newGO = new GameObject(newTransform);
            foreach (Component comp in f_components) {
                comp.Clone(newGO);
            }
            return newGO;
        }

        public T GetComponent<T>() where T : Component {
            for (int i = 0; i < f_components.Count; ++i) {
                if (f_components[i].GetType() == typeof(T)) {
                    return (T)f_components[i];
                }
            }

            return null;
        }

        public void AddComponent(Component c) {
            f_components.Add(c);
        }


        //TODO; how to generate the new thing/ call .CreateInstance() ?
        // public T AddComponent<T>() where T: Component {
        //     typeof(T).c
        //     f_components = T.
        // }

        #endregion
    }

}