namespace LoonyEngine {

    public struct AABB : ICollider2D {

        #region [Properties]

        public Position BottomLeft { get; }
        public Position TopRight { get; }

        public PositionX Left { get { return BottomLeft.x; } }
        public PositionY Bottom { get { return BottomLeft.y; } }
        public PositionX Right { get { return TopRight.x; } }
        public PositionY Top { get { return TopRight.y; } }

        #endregion

        #region [Constructors]

        public AABB(Position bottomLeft, Position topRight) {
            BottomLeft = bottomLeft;
            TopRight = topRight;
        }
        #endregion

        #region [ICollider2D]

        public AABB CreateAABB() {
            return this;
        }

        #endregion

    }

    public struct Circle : ICollider2D {

        #region [Properties]

        public Position Position { get; }
        public PositionMagnitude Radius { get; }

        #endregion

        #region [Constructors]

        public Circle(Position position, PositionMagnitude radius) {
            Position = position;
            Radius = radius;
        }

        #endregion

        #region [ICollider2D]

        public AABB CreateAABB() {
            return new AABB(Position - new Position(Radius.Float, Radius.Float), Position + new Position(Radius.Float, Radius.Float));
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