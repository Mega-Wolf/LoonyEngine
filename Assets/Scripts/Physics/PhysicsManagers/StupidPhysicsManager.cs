using System.Collections.Generic;

namespace LoonyEngine {

    class StupidPhysicsManager : AbstractPhysicsManager {

        #region [FinalVariables]

        private List<Rigidbody> f_rbs = new List<Rigidbody>();
        
        #endregion

        #region [Override]

        public override void Simulate() {
            // Movement phase
            foreach(Rigidbody rb in f_rbs) {
                rb.UpdateDynamics();
                rb.UpdateAABB();
            }

            // CollisionDetectionPhase
            for (int i = 0; i < f_rbs.Count; ++i) {
                for (int j = i + 1; j < f_rbs.Count; ++j) {
                    if (BroadPhase(f_rbs[i], f_rbs[j])) {
                        NarrowPhase(f_rbs[i], f_rbs[j]);
                    }
                }
            }
        }

        public override void AddPhysicsComponent(Rigidbody rb) {
            f_rbs.Add(rb);
        }

        public override void RemovePhysicsComponent(Rigidbody rb) {
            f_rbs.Remove(rb);
        }

        #endregion

    }

}