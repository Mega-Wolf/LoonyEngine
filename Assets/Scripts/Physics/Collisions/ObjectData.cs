namespace LoonyEngine {

    // This struct holds the data about this object which is needed in the collision resolving
    public struct ObjectData {

        // TODO; this could potentially be a link to other data, since there probably aren't that many PhysicsMaterials and memory is rare
        // therefore, this should be an id
        public PhysicsMaterial PhysicsMaterial { get; set; }

        public Mass Mass { get; set; }
        // public Drag Drag { get; set; }
        // public AngularDrag AngularDrag { get; set; }

        public ObjectData(PhysicsMaterial physicsMaterial, Mass mass) {
            this.PhysicsMaterial = physicsMaterial;
            this.Mass = mass;
        }
    }

}