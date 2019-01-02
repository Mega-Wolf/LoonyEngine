namespace LoonyEngine {

    // This holds the information for the collision detection phase
    public struct ColliderData {

        public AABB AABB { get; set; }

        // TODO this is horrible
        public Collider2D Collider2D { get; set; }

        public ColliderData (AABB aabb, Collider2D collider2D) {
            AABB = aabb;
            Collider2D = collider2D;
        }

    }

}