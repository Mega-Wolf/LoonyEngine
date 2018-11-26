using static TemporaryHelperFunctions;

namespace LoonyEngine {

    public static class Intersections {

        public static bool DoIntersectAABBAABB(AABB aabb1, AABB aabb2) {
            return !(aabb1.Right < aabb2.Left || aabb1.Left > aabb2.Right || aabb1.Top < aabb2.Bottom || aabb2.Bottom > aabb2.Top);
        }

        public static Position InterSectAABBAABB(AABB aabb1, AABB aabb2) {
            //TODO
            return new Position(0,0);
        }

        public static bool DoIntersectAABBCircle(AABB aabb, Circle circle) {
            Position closestPosition = ComponentWiseClamp(circle.Position, aabb.BottomLeft, aabb.TopRight);
            return (circle.Position - closestPosition).sqrMagnitude <= circle.Radius * circle.Radius;
        }

        public static Position IntersectAABBCircle(AABB aABB, Circle circle) {
            //TODO
            return new Position(0,0);
        }

        public static bool DoIntersectCircleCircle(Circle circle1, Circle circle2) {
            //TODO; square instead of doing the plus again 
            return (circle1.Position - circle2.Position).sqrMagnitude <= (circle1.Radius + circle2.Radius) * (circle1.Radius + circle2.Radius);
        }

        public static Position IntersectCircleCircle(Circle circle1, Circle circle2) {
            // TODO
            // where exactly is the middle of the intersection?
            // - the exact middle between the circles? 
            // - the weighted middle of the two; depending on their mass or size
            // for now I stick to the first one
            // with a later added resolution Vector, I can then divide the resolutions with the help of the different masses
            return (circle1.Position + circle2.Position) / 2;
        }

        public static bool DoIntersectAABBCapsule(AABB aaabb, Capsule capsule) {
            //TODO
            return false;
        }

        public static Position IntersectAABBCapsule(AABB aabb, Capsule capsule) {
            //TODO
            return new Position(0,0);
        }

        public static bool DoIntersectCircleCapsule(Circle circle, Capsule capsule) {
            //TODO
            return false;
        }

        public static Position IntersectCircleCapsule(Circle circle, Capsule capsule) {
            //TODO
            return new Position(0,0);
        }

        public static bool DoIntersectCapsuleCapsule(Capsule capsule1, Capsule capsule2) {
            //TODO
            return false;
        }
        
        public static Position IntersectCapsuleCapsule(Capsule capsule1, Capsule capsule2) {
            //TODO
            return new Position(0,0);
        }

        public static bool DoIntersectAABBRectangle(AABB aaabb, Rectangle rectangle) {
            //TODO
            return false;
        }

        public static Position IntersectAABBRectangle(AABB aabb, Rectangle rectangle) {
            //TODO
            return new Position(0,0);
        }

        public static bool DoIntersectCircleRectangle(Circle circle, Rectangle rectangle) {
            //TODO
            return false;
        }

        public static Position IntersectCirclerectangle(Circle cirrcle, Rectangle rectangle) {
            //TODO
            return new Position(0,0);
        }

        public static bool DoIntersectCapsuleRectangle(Capsule capsule, Rectangle rectangle) {
            //TODO
            return false;
        }

        public static Position IntersectCapsueRectangle(Capsule capsule, Rectangle rectangle) {
            //TODO
            return new Position(0,0);
        }

        public static bool DoIntersectRectanlgeRectangle(Rectangle rectangle1, Rectangle rectangle2) {
            //TODO
            return false;
        }

        public static Position IntersectRectanlgeREctangle(Rectangle rectangle1, Rectangle rectangle2) {
            //TODO
            return new Position(0,0);
        }

    }

}