using System.Collections.Generic;
using UnityEngine.Profiling;

namespace LoonyEngine {

    /// <summary>
    /// This PM is like the StupidPM, but instead of having a giant list with RBs, every layer has its own list
    /// </summary>
    public class BetterLayersPM : AbstractPhysicsManager {

        // + 
        // Way faster broad phase due to a lot less collision checks (if layers are used like that)

        // -
        // Additional actions have to happen, if the layer wants to be changed
        // The PM has to be informed about a layer change

        #region [FinalVariables]

        List<List<Rigidbody>> f_rigidbodies = new List<List<Rigidbody>>();

        #endregion

        #region [Properties]

        public override IEnumerable<Rigidbody> Rigidbodies {
            get {
                for (int i = 0; i < f_rigidbodies.Count; ++i) {
                    for (int j = 0; j < f_rigidbodies[i].Count; ++j) {
                        yield return f_rigidbodies[i][j];
                    }
                }
            }
        }

        #endregion

        #region [Override]

        public override void Simulate() {
            base.Simulate();

            // Movement phase
            Profiler.BeginSample("BetterLayer; Movement Phase");
            for (int i = 0; i < f_rigidbodies.Count; ++i) {
                for (int j = 0; j < f_rigidbodies[i].Count; ++j) {
                    f_rigidbodies[i][j].UpdateDynamics();
                    f_rigidbodies[i][j].UpdateAABB();
                    ++m_moved;
                }
            }
            Profiler.EndSample();

            // CollisionDetectionPhase
            Profiler.BeginSample("BetterLayer; Collision Phase");
            for (int l = 0; l < f_rigidbodies.Count; ++l) {
                for (int l2 = 0; l2 < f_rigidbodies.Count; ++l2) {
                    if (!f_physicsMatrix.DoCollide(l, l2)) {
                        continue;
                    }

                    if (l == l2) {
                        for (int i = 0; i < f_rigidbodies[l].Count; ++i) {
                            for (int j = i + 1; j < f_rigidbodies[l2].Count; ++j) {
                                if (BroadPhase(f_rigidbodies[l][i], f_rigidbodies[l2][j])) {
                                    NarrowPhase(f_rigidbodies[l][i], f_rigidbodies[l2][j]);
                                }
                            }
                        }
                    } else {
                        for (int i = 0; i < f_rigidbodies[l].Count; ++i) {
                            for (int j = 0; j < f_rigidbodies[l2].Count; ++j) {
                                if (BroadPhase(f_rigidbodies[l][i], f_rigidbodies[l2][j])) {
                                    NarrowPhase(f_rigidbodies[l][i], f_rigidbodies[l2][j]);
                                }
                            }
                        }
                    }
                }
            }

            Profiler.EndSample();


            // TODO the resolution has to be incremental
            // somwhere I need information whether this collision should stop etc or not

            // Profiler.BeginSample("BetterLayer; Resolve Phase");
            // foreach (ulong rbsID in m_collisionsThisFrame.Keys) {
            //     uint id1 = (uint)rbsID;
            //     uint id2 = (uint) (rbsID >> 32);
            // }
            // Profiler.EndSample();
        }

        public override void AddPhysicsComponent(Rigidbody rb) {
            f_rigidbodies[rb.ColliderData.LayerNumber].Add(rb);
        }

        public override void RemovePhysicsComponent(Rigidbody rb) {
            f_rigidbodies[rb.ColliderData.LayerNumber].Remove(rb);
        }

        public override void ChangeLayer(Rigidbody rb, int oldLayerNumber, int newLayerNumber) {
            f_rigidbodies[oldLayerNumber].Remove(rb);
            f_rigidbodies[newLayerNumber].Add(rb);
        }

        public override void SetPhysicsMatrix(PhysicsMatrix physicsMatrix) {
            base.SetPhysicsMatrix(physicsMatrix);

            int layers = physicsMatrix.Size;
            if (f_rigidbodies.Count > layers) {
                // Don't ask me what then happens to the rbs in there
                f_rigidbodies.RemoveRange(layers, f_rigidbodies.Count - layers);
            }

            while (f_rigidbodies.Count < layers) {
                f_rigidbodies.Add(new List<Rigidbody>());
            }
        }

        #endregion

    }

}