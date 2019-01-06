namespace LoonyEngine {

    /// <summary>
    /// The result of a collision
    /// </summary>
    public struct CollisionDataRB {

        public Position CollisionNormal { get; set; }
        public PositionMagnitude PenetrationDepth { get; set; }
        public Rigidbody RigidBody1 { get; set; }
        public Rigidbody RigidBody2 { get; set; }

        #region [Properties]

        public bool DidCollide { get { return PenetrationDepth > new PositionMagnitude(0); } }

        #endregion

        #region [Constructors]

        public CollisionDataRB(Position collisionNormal, PositionMagnitude penetrationDepth, Rigidbody rigidbody1, Rigidbody rigidbody2) {
            CollisionNormal = collisionNormal;
            PenetrationDepth = penetrationDepth;
            RigidBody1 = rigidbody1;
            RigidBody2 = rigidbody2;
        }

        #endregion
    }

}