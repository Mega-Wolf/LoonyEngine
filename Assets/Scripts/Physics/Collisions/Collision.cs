namespace LoonyEngine {

    public struct Collision {

        #region [Properties]

        public bool DoCollide { get; }
        public Position Position { get; }

        //Resolving force

        // TODO
        // The different colliders
        // What colliders; probably the actual colliders
        // That means this is only used by a user


        #endregion
        //TODO


        // colision depth

        // for now only have the struct with all values set

        #region [Constructors]

        public Collision(bool doCollide, Position position) {
            DoCollide = doCollide;
            Position = position;
        }

        #endregion
    }



}
