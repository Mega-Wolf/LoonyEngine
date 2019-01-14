using System.Collections.Generic;
using UnityEngine.Profiling;

namespace LoonyEngine {

    /// <summary>
    /// A PhysicsManager which just does the simple n * n check
    /// </summary>
    class StupidPhysicsManager : AbstractPhysicsManager {

        #region [FinalVariables]

        private List<Rigidbody> f_rbs = new List<Rigidbody>();

        #endregion

        #region [Properties]

        public override IEnumerable<Rigidbody> Rigidbodies { get { return f_rbs; } }

        public override string Name { get { return "Stupid PhysicsManager"; } }

        #endregion

        #region [Constructors]

        public StupidPhysicsManager() {
            f_oois.Add(new ObjectOrderInformation<Rigidbody>("Rigidbody positions:", f_rbs, (rb) => { return (int)rb.ID; }));
        }

        #endregion

        #region [Override]

        public override void Simulate() {
            base.Simulate();

            /* Movement phase */
            {
                Profiler.BeginSample("Stupid; Movement Phase");
                f_stopwatch.Restart();
                foreach (Rigidbody rb in f_rbs) {
                    rb.UpdateDynamics();
                    rb.UpdateAABB();
                    ++m_moved;
                }
                f_stopwatch.Stop();
                m_movementTime = f_stopwatch.Elapsed;
                Profiler.EndSample();
            }

            /* CollisionDetectionPhase */
            {
                Profiler.BeginSample("Stupid; Collision Phase");
                f_stopwatch.Restart();
                for (int i = 0; i < f_rbs.Count; ++i) {
                    for (int j = i + 1; j < f_rbs.Count; ++j) {
                        if (BroadPhase(f_rbs[i], f_rbs[j])) {
                            NarrowPhase(f_rbs[i], f_rbs[j]);
                        }
                    }
                }
                f_stopwatch.Stop();
                m_collisionTime = f_stopwatch.Elapsed;
                Profiler.EndSample();
            }

            // TODO the resolution has to be incremental
            // This stuff at the moment happens in the narrow phase
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