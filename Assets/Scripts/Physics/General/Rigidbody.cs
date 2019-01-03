namespace LoonyEngine {

    public class Rigidbody : Component {

        public DynamicData DynamicData { get; set; }
        public ObjectData ObjectData { get; set; }
        public ColliderData ColliderData { get; set; }

        public Rigidbody(GameObject gameObject) : base(gameObject) {

        }

        public void UpdateDynamics() {
            //TODO
        }

        public void UpdateAABB() {
            //TODO
        }

    }

}