namespace LoonyEngine {

    public class Rigidbody : Component {

        public DynamicData DynamicData { get; set; }
        public ObjectData ObjectData { get; set; }
        public ColliderData ColliderData { get; set; }

        public Rigidbody(GameObject gameObject) : base(gameObject) {}

        public void UpdateDynamics() {
            //TODO; this has a lot ov overhead and will be changed later on
            DynamicData dd = DynamicData;
            dd.Velocity += DynamicData.Acceleration * SuperPhysicsManager.Instance.DELTA_TIME;
            DynamicData = dd;

            // TODO; it might not be possible to do that in the future (calling transform directly)
            GameObject.Transform.Position += DynamicData.Velocity * SuperPhysicsManager.Instance.DELTA_TIME;
        }

        public void UpdateAABB() {
            //TODO
            // That is dependend on the collider data
        }

    }

}