namespace LoonyEngine {

    public class Rigidbody : Component {

        public DynamicData DynamicData { get; set; }
        public ObjectData ObjectData { get; set; }
        public ColliderData ColliderData { get; set; }

        public Rigidbody(GameObject gameObject, DynamicData dynamicData, ObjectData objectData, ColliderData colliderData) : base(gameObject) {
            DynamicData = dynamicData;
            ObjectData = objectData;
            ColliderData = colliderData;
        }

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

        public override Component Clone(GameObject gameObject) {
            Rigidbody rb = new Rigidbody(gameObject, DynamicData, ObjectData, ColliderData);
            gameObject.AddComponent(rb);
            return rb;
        }
    }
}