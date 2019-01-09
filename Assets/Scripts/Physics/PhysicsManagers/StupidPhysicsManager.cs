using System.Collections.Generic;
using UnityEngine.Profiling;

namespace LoonyEngine {

    class StupidPhysicsManager : AbstractPhysicsManager {

        #region [FinalVariables]

        private List<Rigidbody> f_rbs = new List<Rigidbody>();

        #endregion

        #region [Properties]

        public override IEnumerable<Rigidbody> Rigidbodies { get { return f_rbs; } }

        #endregion

        #region [Constructors]

        public StupidPhysicsManager() {
            f_oois.Add(new ObjectOrderInformation<Rigidbody>("Rigidbody positions:", f_rbs, (rb) => { return (int)rb.ID; }));
        }

        #endregion

        #region [Override]

        public override void Simulate() {
            base.Simulate();

            // Movement phase
            Profiler.BeginSample("Stupid; Movement Phase");
            foreach (Rigidbody rb in f_rbs) {
                rb.UpdateDynamics();
                rb.UpdateAABB();
                ++m_moved;
            }
            Profiler.EndSample();

            // CollisionDetectionPhase

            Profiler.BeginSample("Stupid; Collision Phase");
            for (int i = 0; i < f_rbs.Count; ++i) {
                for (int j = i + 1; j < f_rbs.Count; ++j) {
                    if (BroadPhase(f_rbs[i], f_rbs[j])) {
                        NarrowPhase(f_rbs[i], f_rbs[j]);
                    }
                }
            }
            Profiler.EndSample();


            // TODO the resolution has to be incremental
            // somwhere I need information whether this collision should stop etc or not

            // Profiler.BeginSample("Stupid; Resolve Phase");
            // foreach (ulong rbsID in m_collisionsThisFrame.Keys) {
            //     uint id1 = (uint)rbsID;
            //     uint id2 = (uint) (rbsID >> 32);
            // }
            // Profiler.EndSample();
        }

        public override void AddPhysicsComponent(Rigidbody rb) {
            f_rbs.Add(rb);
        }

        public override void RemovePhysicsComponent(Rigidbody rb) {
            f_rbs.Remove(rb);
        }

        public override void ChangeLayer(Rigidbody rb, int oldLayerNumber, int newLayerNumber) {
            // dont care
        }

        #endregion

    }

}