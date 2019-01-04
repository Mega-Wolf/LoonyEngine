using System.Collections.Generic;

namespace LoonyEngine {

    public class Rigidbody : Component {

        #region [Static]

        private static Pooler<Rigidbody> s_pooler = SuperPooler.Instance.GetPooler<Rigidbody>();

        private static Dictionary<uint, Rigidbody> s_rbs = new Dictionary<uint, Rigidbody>();

        public static Rigidbody GetRigidbody(uint id) {
            return s_rbs[id];
        }

        #endregion

        #region [Variables/Properties]

        public DynamicData DynamicData { get; set; }
        public ObjectData ObjectData { get; set; }
        public ColliderData ColliderData { get; set; }

        #endregion

        #region [Constructors]

        public Rigidbody() : base() {
            s_rbs[ID] = this;
        }

        public static Rigidbody New(DynamicData dynamicData, ObjectData objectData, ColliderData colliderData) {
            Rigidbody rb = s_pooler.GetInstance();
            rb.Init(dynamicData, objectData, colliderData);
            return rb;
        }

        #endregion

        #region [Init]

        public void Init(DynamicData dynamicData, ObjectData objectData, ColliderData colliderData) {
            DynamicData = dynamicData;
            ObjectData = objectData;
            ColliderData = colliderData;
        }

        #endregion

        #region [PublicMethods]

        public void UpdateDynamics() {
            //TODO; this has a lot of overhead and will be changed later on
            DynamicData dd = DynamicData;
            dd.Velocity += DynamicData.Acceleration * SuperPhysicsManager.Instance.DELTA_TIME;
            DynamicData = dd;

            // TODO; it might not be possible to do that in the future (calling transform directly)
            GameObject.Transform.Position += DynamicData.Velocity * SuperPhysicsManager.Instance.DELTA_TIME;
        }

        public void UpdateAABB() {
            //TODO; this is as ugly as the DynamicData above
            ColliderData cd = ColliderData;
            cd.GlobalAABB = cd.Collider2D.CreateAABB(GameObject.Transform);
            ColliderData = cd;
        }

        #endregion

        #region [Override]

        public override Component Clone(GameObject gameObject) {
            Rigidbody rb = Rigidbody.New(DynamicData, ObjectData, ColliderData);
            gameObject.AddComponent(rb);
            return rb;
        }

        public override void Release() {
            s_pooler.ReleaseInstance(this);
        }

        #endregion
    }
}