namespace LoonyEngine {

    // This holds the information for the collision detection phase
    public struct ColliderData {

        public AABB AABB { get; set; }

        // TODO this is horrible
        public Collider2D Collider2D { get; set; }

        public bool IsTrigger { get; set; }
        // callback to the different things (Enter, Stay, Exit - Trigger,Collision)

        public ColliderData(AABB aabb, Collider2D collider2D, bool isTrigger) {
            AABB = aabb;
            Collider2D = collider2D;
            IsTrigger = isTrigger;
        }

    }

}