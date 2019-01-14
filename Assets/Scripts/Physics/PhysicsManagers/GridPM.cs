using System.Collections.Generic;
using UnityEngine.Profiling;

namespace LoonyEngine {

    /// <summary>
    /// A PhysicsManager using a grid
    /// </summary>
    public class GridPM : AbstractPhysicsManager {

        #region [PrivateVariables]

        private List<Rigidbody> f_rbs = new List<Rigidbody>();

        private Grid f_grid;

        private HashSet<ulong> f_broadChecks = new HashSet<ulong>();

        #endregion

        #region [Properties]

        public override IEnumerable<Rigidbody> Rigidbodies { get { return f_rbs; } }

        public override string Name { get { return "Grid Physics Manager"; } }

        #endregion

        #region [Constructors]

        public GridPM() {
            f_grid = new Grid(new PositionMagnitude(3f), 2 * Level.Instance.LevelBounds + -Level.Instance.LevelBounds.Centre);
        }

        #endregion

        #region [Override]

        public override void Simulate() {
            base.Simulate();

            /* Movement phase */
            {
                Profiler.BeginSample("QT; Movement Phase");
                f_stopwatch.Restart();
                foreach (Rigidbody rb in f_rbs) {
                    AABB oldABB = rb.ColliderData.GlobalAABB;
                    rb.UpdateDynamics();
                    rb.UpdateAABB();
                    ++m_moved;
                    f_grid.Move(rb, oldABB, rb.ColliderData.GlobalAABB);
                }
                f_stopwatch.Stop();
                m_movementTime = f_stopwatch.Elapsed;
                Profiler.EndSample();
            }

            /* CollisionDetectionPhase */
            {
                f_broadChecks.Clear();
                Profiler.BeginSample("QT; Collision Phase");
                f_stopwatch.Restart();
                for (int i = 0; i < f_rbs.Count; ++i) {
                    foreach (Rigidbody rb2 in f_grid.IntersectHigher(f_rbs[i])) {

                        // This prevents that some pairs get tested multiple times
                        if (f_broadChecks.Contains(CalcRBID(f_rbs[i], rb2))) {
                            continue;
                        }
                        f_broadChecks.Add(CalcRBID(f_rbs[i], rb2));

                        if (BroadPhase(f_rbs[i], rb2, true)) {
                            NarrowPhase(f_rbs[i], rb2);
                        }
                    }
                }
                f_stopwatch.Stop();
                m_collisionTime = f_stopwatch.Elapsed;
                Profiler.EndSample();
            }
        }

        public override void AddPhysicsComponent(Rigidbody rb) {
            f_rbs.Add(rb);
            rb.UpdateAABB();
            f_grid.Insert(rb);
        }

        public override void ChangeLayer(Rigidbody rb, int oldLayerNumber, int newLayerNumber) {
            // empty
        }

        public override void RemovePhysicsComponent(Rigidbody rb) {
            f_rbs.Remove(rb);
            rb.UpdateAABB();
            f_grid.Remove(rb, rb.ColliderData.GlobalAABB);
        }

        #endregion

        #region [Visuals]

        public override void Draw(UnityEngine.Vector2 offset) {
            f_grid.Draw(offset);
        }

        #endregion
    }

}