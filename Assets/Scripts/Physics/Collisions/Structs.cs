namespace LoonyEngine {

    public struct AABB : ICollider2D {

        #region [Operators]

        public static AABB operator +(AABB aabb, Position offset) {
            return new AABB(aabb.BottomLeft + offset, aabb.TopRight + offset);
        }

        public static AABB operator *(float scale, AABB aabb) {
            return new AABB(scale * aabb.BottomLeft, scale * aabb.TopRight);
        }

        public static AABB operator /(AABB aabb, float divider) {
            return new AABB(aabb.BottomLeft / divider, aabb.TopRight / divider);
        }

        public static AABB operator *(Transform2D transform, AABB aabb) {
            return transform.Scale * aabb + transform.Position;
        }

        #endregion

        #region [Properties]

        public Position BottomLeft { get; }
        public Position TopRight { get; }

        public PositionX Left { get { return BottomLeft.x; } }
        public PositionY Bottom { get { return BottomLeft.y; } }
        public PositionX Right { get { return TopRight.x; } }
        public PositionY Top { get { return TopRight.y; } }

        public Position Centre { get { return (BottomLeft + TopRight) / 2; } }

        public AABB BottomLeftAABB { get { return new AABB(BottomLeft, Centre); } }
        public AABB BottomRightAABB { get { return new AABB(new Position(Centre.x.Float, Bottom.Float), new Position(Right.Float, Centre.y.Float)); } }
        public AABB TopLeftAABB { get { return new AABB(new Position(Left.Float, Centre.y.Float), new Position(Centre.x.Float, Top.Float)); } }
        public AABB TopRightAABB { get { return new AABB(Centre, TopRight); } }

        #endregion

        #region [Constructors]

        public AABB(Position bottomLeft, Position topRight) {
            BottomLeft = bottomLeft;
            TopRight = topRight;
        }

        #endregion

        #region [ICollider2D]

        public AABB CreateAABB(Transform2D transform) {
            return transform.Scale * this + transform.Position;
        }

        #endregion

        #region [Override]

        public override string ToString() {
            return "AABB: X: (" + Left.Float + " - " + Right.Float + ") - Y: (" + Bottom.Float + " - " + Top.Float + ")";
        }

        #endregion

    }

    public struct Circle : ICollider2D {

        #region [Properties]

        //public Position Position { get; }
        public PositionMagnitude Radius { get; }

        #endregion

        #region [Constructors]

        public Circle(/*Position position, */PositionMagnitude radius) {
            //Position = position;
            Radius = radius;
        }

        #endregion

        #region [ICollider2D]

        public AABB CreateAABB(Transform2D transform) {
            return new AABB(transform.Position - transform.Scale * new Position(Radius.Float, Radius.Float), transform.Position + transform.Scale * new Position(Radius.Float, Radius.Float));
        }

        #endregion

        #region [Override]

        public override string ToString() {
            return "Circle: - r: " + Radius;
        }

        #endregion

    }

    public struct Capsule {

        #region [Properties]

        public Position Position1 { get; }
        public Position Position2 { get; }
        public PositionMagnitude Radius { get; }

        #endregion

        #region [Constructors]

        public Capsule(Position position1, Position position2, PositionMagnitude radius) {
            Position1 = position1;
            Position2 = position2;
            Radius = radius;
        }

        #endregion

    }

    public struct Rectangle {

        #region [Properties]

        public Position Position { get; }
        public Angle Angle { get; }

        #endregion

        #region [Constructors]

        public Rectangle(Position position, Angle angle) {
            Position = position;
            Angle = angle;
        }

        #endregion
    }

}