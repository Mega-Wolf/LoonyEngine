using static TemporaryHelperFunctions;

namespace LoonyEngine {

    public static class Intersections {

        public static bool DoIntersectAABBAABB(AABB aabb1, AABB aabb2) {
            return !(aabb1.Right < aabb2.Left || aabb1.Left > aabb2.Right || aabb1.Top < aabb2.Bottom || aabb2.Bottom > aabb2.Top);
        }

        public static bool DoIntersectAABBCircle(AABB aabb, Circle circle) {            
            Position closestPosition = ComponentWiseClamp(circle.Position, aabb.BottomLeft, aabb.TopRight);
            return (circle.Position - closestPosition).sqrMagnitude <= circle.Radius * circle.Radius;
        }

        public static bool DoIntersectCircleCircle(Circle circle1, Circle circle2) {
            //return (circle1.Position - circle2.Position).sqrMagnitude <= (circle1.Radius + circle2.Radius) * (circle1.Radius + circle2.Radius);
            //TODO
            return false;
        }

        public static bool DoIntersectAABBCapsule(AABB aaabb, Capsule capsule) {
            //TODO
            return false;
        }

        public static bool DoIntersectCircleCapsule(Circle circle, Capsule capsule) {
            //TODO
            return false;
        }

        public static bool DoIntersectCapsuleCapsule(Capsule capsule1, Capsule capsule2) {
            //TODO
            return false;
        }

    }

}