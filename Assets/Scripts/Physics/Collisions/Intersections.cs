using static TemporaryHelperFunctions;

namespace LoonyEngine {

    public static class Intersections {

        #region [AABB]

        public static bool DoIntersectAABBAABB(AABB aabb1, AABB aabb2) {
            return !(aabb1.Right < aabb2.Left || aabb1.Left > aabb2.Right || aabb1.Top < aabb2.Bottom || aabb1.Bottom > aabb2.Top);
        }

        public static Position IntersectAABBAABB(AABB aabb1, AABB aabb2) {
            Position mins = Position.Min(aabb1.TopRight, aabb2.TopRight);
            Position maxs = Position.Max(aabb1.BottomLeft, aabb2.BottomLeft);
            return (mins + maxs) / 2;
        }

        public static CollisionData CollisionAABBAABB(AABB aabb1, AABB aabb2) {
            // bool doIntersect = DoIntersectAABBAABB(aabb1, aabb2);
            // Position position = IntersectAABBAABB(aabb1, aabb2);

            //TODO calculate resolving vector

            // I have to find out on which side the boxes collide

            return new CollisionData();

            //return new Collision(doIntersect, position);
        }

        #endregion

        // #region [+ Circle]

        // #region [AABBCircle]

        // public static bool DoIntersectAABBCircle(AABB aabb, Circle circle) {
        //     Position closestPosition = ComponentWiseClamp(circle.Position, aabb.BottomLeft, aabb.TopRight);
        //     return (circle.Position - closestPosition).sqrMagnitude <= circle.Radius * circle.Radius;
        // }

        // public static Position IntersectAABBCircle(AABB aABB, Circle circle) {
        //     //TODO
        //     // not sure where the middle point of those is
        //     // I can find the closest point on the rect to the circle
        //     // Should I just take the middle of that point and ...? what?
        //     return new Position(0, 0);
        // }

        // public static Collision CollisionAABBCircle(AABB aabb, Circle circle) {
        //     bool doIntersect = DoIntersectAABBCircle(aabb, circle);
        //     Position position = IntersectAABBCircle(aabb, circle);

        //     //TODO calculate resolving vector

        //     return new Collision(doIntersect, position);
        // }

        // #endregion

        // #region [CircleCircle]

        // public static bool DoIntersectCircleCircle(Circle circle1, Circle circle2) {
        //     PositionMagnitude maxRadius = circle1.Radius + circle2.Radius;
        //     return (circle1.Position - circle2.Position).sqrMagnitude <= maxRadius * maxRadius;
        // }

        // public static Position IntersectCircleCircle(Circle circle1, Circle circle2) {
        //     return (circle1.Position + circle2.Position) / 2;
        // }

        // public static CollisionData CollisionCircleCircle(Circle circle1, Circle circle2) {
        //     // bool doIntersect = DoIntersectCircleCircle(circle1, circle2);
        //     // Position position = IntersectCircleCircle(circle1, circle2);

        //     //(circle2.Position - circle1.Position)
        //     //circle1.Position + (circle2.Position - circle1.Position). normalized * (circle1.Radius + circle2.Radius)
        //     //Position.

        //     // positionA --- positionB = fullDistance eg 10
        //     // rA + rB = rGes eg 15
        //     // rGes - fullDistance = penetrationDepth eg 15 - 10 = 5
        //     // penetrationDepth / 2 = halfDepth (macht weniger Sinn)

        //     Position collisionVector = circle2.Position - circle1.Position;

        //     // OPT: This has to be done to prevent a division by zero; however, this occurs very rearly and the result of using it would be undefined anyway
        //     // the normalisation could be ommited in the if, but for GPUs it might be more effective for better streamlining to still do it
        //     // (is this actually true; in both cases I have to do it)
        //     if (collisionVector == new Position(0,0)) {
        //         collisionVector = new Position(1, 0);
        //     }

        //     PositionMagnitude penetrationDepth = (circle1.Radius + circle2.Radius) - collisionVector.magnitude;
        //     return new CollisionData(collisionVector.normalized, penetrationDepth);

        //     //return new Collision(doIntersect, position);
        // }

        // #endregion

        // #endregion

        #region [+ Capsule]

        public static bool DoIntersectAABBCapsule(AABB aaabb, Capsule capsule) {
            //TODO
            return false;
        }

        public static Position IntersectAABBCapsule(AABB aabb, Capsule capsule) {
            //TODO
            return new Position(0, 0);
        }

        public static bool DoIntersectCircleCapsule(Circle circle, Capsule capsule) {
            //TODO
            return false;
        }

        public static Position IntersectCircleCapsule(Circle circle, Capsule capsule) {
            //TODO
            return new Position(0, 0);
        }

        public static bool DoIntersectCapsuleCapsule(Capsule capsule1, Capsule capsule2) {
            //TODO
            return false;
        }

        public static Position IntersectCapsuleCapsule(Capsule capsule1, Capsule capsule2) {
            //TODO
            return new Position(0, 0);
        }

        #endregion

        #region [+ Rectangle]

        public static bool DoIntersectAABBRectangle(AABB aaabb, Rectangle rectangle) {
            //TODO
            return false;
        }

        public static Position IntersectAABBRectangle(AABB aabb, Rectangle rectangle) {
            //TODO
            return new Position(0, 0);
        }

        public static bool DoIntersectCircleRectangle(Circle circle, Rectangle rectangle) {
            //TODO
            return false;
        }

        public static Position IntersectCirclerectangle(Circle cirrcle, Rectangle rectangle) {
            //TODO
            return new Position(0, 0);
        }

        public static bool DoIntersectCapsuleRectangle(Capsule capsule, Rectangle rectangle) {
            //TODO
            return false;
        }

        public static Position IntersectCapsueRectangle(Capsule capsule, Rectangle rectangle) {
            //TODO
            return new Position(0, 0);
        }

        public static bool DoIntersectRectanlgeRectangle(Rectangle rectangle1, Rectangle rectangle2) {
            //TODO
            return false;
        }

        public static Position IntersectRectanlgeREctangle(Rectangle rectangle1, Rectangle rectangle2) {
            //TODO
            return new Position(0, 0);
        }

        #endregion

    }

}