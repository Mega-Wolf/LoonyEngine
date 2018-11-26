using System.Collections.Generic;

namespace LoonyEngine {

    public class PhysicsManager : MBSingleton<PhysicsManager> {

        #region [Consts]

        public readonly Time DELTA_TIME = new Time(1 / 50f);

        #endregion

        #region [FinalVariables]

        private readonly List<Transform2D> f_transforms = new List<Transform2D>();
        private readonly List<Rigidbody> f_rbs = new List<Rigidbody>();

        #endregion

        #region [Updates]

        private void FixedUpdate() {
            // TODO; How to handle multiple forces at the same time?

            // Movement phase
            for (int i = 0; i < f_transforms.Count; ++i) {
                
                // TODO; LoonyEngine
                f_rbs[i] = new Rigidbody(f_rbs[i].Velocity + f_rbs[i].Acceleration * DELTA_TIME, f_rbs[i].Acceleration);
                //f_rbs[i].Velocity += f_rbs[i].Acceleration * DELTA_TIME;


                f_transforms[i].Position += f_rbs[i].Velocity * DELTA_TIME;
            }

            // TODO collision phase
        }

        #endregion

        #region [PublicMethods]

        public void AddPhysicsComponent(Collider2D physicsComponent) {
            f_transforms.Add(physicsComponent.GameObject.Transform);
            //f_rbs.Add(physicsComponent.GameObject);
            //TODO
        }

        public void RemovePhysicsComponent(Collider2D physicsComponent) {
            f_transforms.Remove(physicsComponent.GameObject.Transform);
            //f_rbs.Remove();
            //TODO
        }

        // add to collisions
        // add to triggers
        // etc.
        // making physics casts
        // making raycasts

        #endregion

    }

}