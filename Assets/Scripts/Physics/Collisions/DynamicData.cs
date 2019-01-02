namespace LoonyEngine {

    // This holds the data of a dynamic object
    // This is needed for the movement phase
    public struct DynamicData {

        public Velocity Velocity { get; set; }
        public Acceleration Acceleration { get; set; }

        // public AngularSpeed AngularSpeed { get; set; }
        // public AngularAcceleration AngularAcceleration { get; set; }

        public DynamicData(Velocity velocity, Acceleration acceleration) {
            Velocity = velocity;
            Acceleration = acceleration;
        }
    }
}