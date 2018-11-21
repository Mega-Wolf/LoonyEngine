namespace LoonyEngine {

    public struct Rigidbody {

        public Velocity Velocity { get; set; }
        public Acceleration Acceleration { get; set; }

        //RotationVelocity float
        //RotationAcceleration float

        public Rigidbody (Velocity velocity, Acceleration acceleration) {
            Velocity = velocity;
            Acceleration = acceleration;
        }
    }

}