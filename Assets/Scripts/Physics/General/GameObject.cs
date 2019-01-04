using System.Collections.Generic;

namespace LoonyEngine {

    public class GameObject {

        #region [Statics]

        private static Pooler<GameObject> s_pooler = SuperPooler.Instance.GetPooler<GameObject>();

        public static void Release(GameObject go) {
            
            Transform2D.Release(go.Transform);
            foreach (Component component in go.f_components) {
                component.Release();
            }

            go.f_components.Clear();

            s_pooler.ReleaseInstance(go);
        }

        #endregion

        #region [FinalVariables]

        private List<Component> f_components = new List<Component>();
        private Transform2D f_transform;

        #endregion

        #region [PrivateVariables]

        private string m_name;

        #endregion

        #region [Properties]

        public Transform2D Transform { get { return f_transform; } }

        #endregion

        #region [Constructors]

        public static GameObject New(Transform2D transform2D) {
            GameObject go = s_pooler.GetInstance();
            go.Init(transform2D);
            return go;
        }

        #endregion

        #region [Init]

        public void Init(Transform2D transform2D) {
            f_transform = transform2D;
        }

        #endregion

        #region [PublicMethods]

        public GameObject CloneLeave() {
            Transform2D newTransform = Transform2D.New(null);

            newTransform.Position = Transform.Position;
            newTransform.Angle = Transform.Angle;
            newTransform.Scale = Transform.Scale;

            GameObject newGO = GameObject.New(newTransform);
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
            c.AttachGO(this);
        }

        #endregion

    }

}