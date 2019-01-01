namespace LoonyEngine {

    public struct CollisionData {
        Position CollisionNormal;

        // if negative = they do not collide
        PositionMagnitude PenetrationDepth;

        public CollisionData(Position collisionNormal, PositionMagnitude penetrationDepth) {
            CollisionNormal = collisionNormal;
            PenetrationDepth = penetrationDepth;
        }
    }

}