using System.Collections.Generic;

namespace LoonyEngine {

    public sealed class Transform2D {

        //TODO; how about putting most of the logic to GO and only having the Position and angle as Transform Data => way less space for transforms

        #region [PrivateVariables]

        // isStatic
        // static rot
        // static loc
        // static scale
        // layer

        private Angle m_angle;
        private Position m_position;

        private Transform2D m_parent;
        private List<Transform2D> m_children;

        #endregion

        #region [Properties]

        public Transform2D Parent { get { return m_parent; } }

        public Position Position {
            get {
                return m_position;
            }
            set {
                m_position = value;
                Update();
            }
        }

        public Angle Angle {
            get {
                return m_angle;
            }
            set {
                m_angle = value;
                Update();
            }
        }

        #endregion

        #region [Constructors]

        public Transform2D(Transform2D parent) {
            m_parent = parent;
            m_children = new List<Transform2D>();
        }

        #endregion

        #region [PublicMethods]

        public void SetTransform(Position position, Angle angle) {
            m_position = position;
            m_angle = angle;
            Update();
        }

        #endregion

        #region [PrivateMethods]

        private void Update() {
            // TODO
            // update the values in here
            for (int i = 0; i < m_children.Count; ++i) {
                m_children[i].Update();
            }
            //react on values here (AABB is only caluclateable after children have done their stuff)
        }

        // TODO; AABB in Physics or in Transform?

        // private void CalculateAABB() {

        // }

        #endregion

    }

}