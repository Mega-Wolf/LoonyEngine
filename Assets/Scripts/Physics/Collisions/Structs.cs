namespace LoonyEngine {

    public struct AABB {

        #region [Private Variables]

        private Position TopLeft;
        private Position BottomRight;

        #endregion

        #region [Properties]

        public PositionX Left { get { return TopLeft.x; } }
        public PositionX Right { get { return BottomRight.x; } }
        public PositionY Top { get { return TopLeft.y; } }
        public PositionY Bottom { get { return BottomRight.y; } }

        #endregion

        #region [Constructors]

        public AABB(Position topLeft, Position bottomRight) {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        #endregion

    }

    public struct Circle {

        #region [PrivateVariables]

        public Position Position { get; }
        public PositionMagnitude Radius { get; }

        #endregion

        #region [Constructors]

        public Circle(Position position, PositionMagnitude radius) {
            Position = position;
            Radius = radius;
        }

        #endregion

    }

    public struct Capsule {

        #region [PrivateVariables]

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

}