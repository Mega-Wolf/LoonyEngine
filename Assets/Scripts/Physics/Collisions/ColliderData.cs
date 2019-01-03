namespace LoonyEngine {

    // This holds the information for the collision detection phase
    public struct ColliderData {

        public AABB AABB { get; set; }

        // TODO this is horrible
        // actually now it is a boxed struct
        // Since I had this differently in mind I should clarify: Having the colllider data on every object makes actually sense for simple shapes since they do not really have any data anyway
        // or well, does it...
        // it would be an index instead of e.g. 2 positions and a radius of a capsule (5 floats)
        // this way, ALL ColliderDatas would be the same size which would actually be very cool
        // therefore, stick to the original idea :D
        // Colliders always have relative data
        // That has to be calculated to get the actual collider position and orientation
        public ICollider2D Collider2D { get; set; }

        public bool IsTrigger { get; set; }

        // MISSING callback to the different things (Enter, Stay, Exit - Trigger,Collision)

        public ColliderData(ICollider2D collider2D, bool isTrigger, Transform2D transform) {
            Collider2D = collider2D;
            IsTrigger = isTrigger;

            AABB = Collider2D.CreateAABB(transform);
        }

    }

}