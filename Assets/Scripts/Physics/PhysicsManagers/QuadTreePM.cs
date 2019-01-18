#if UNITY_EDITOR
using UnityEditor;
#endif

using System.Collections.Generic;
using UnityEngine.Profiling;

namespace LoonyEngine {

    /// <summary>
    /// A PhysicsManager using a QuadTree
    /// </summary>
    public class QuadTreePM : AbstractPhysicsManager {

        #region [PrivateVariables]

        private List<Rigidbody> f_rbs = new List<Rigidbody>();

        private QuadTree f_quadtree;

        private HashSet<ulong> f_broadChecks = new HashSet<ulong>();

        #endregion

        #region [Properties]

        public override IEnumerable<Rigidbody> Rigidbodies { get { return f_rbs; } }

        public override string Name { get { return "QuadTree Physics Manager"; } }

        #endregion

        #region [Constructors]

        public QuadTreePM() {
            f_quadtree = QuadTree.New(2 * Level.Instance.LevelBounds + -Level.Instance.LevelBounds.Centre, 0);
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
                    f_quadtree.Move(rb, oldABB, rb.ColliderData.GlobalAABB);
                }
                f_stopwatch.Stop();
                m_movementTime = f_stopwatch.Elapsed;
                Profiler.EndSample();
            }

            /* CollisionDetection phase */
            {

                f_broadChecks.Clear();

                Profiler.BeginSample("QT; Collision Phase");

                f_stopwatch.Restart();
                for (int i = 0; i < f_rbs.Count; ++i) {
                    foreach (Rigidbody rb2 in f_quadtree.IntersectHigher(f_rbs[i])) {

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
            f_quadtree.Insert(rb);
        }

        public override void ChangeLayer(Rigidbody rb, int oldLayerNumber, int newLayerNumber) {
            // empty
        }

        public override void RemovePhysicsComponent(Rigidbody rb) {
            f_rbs.Remove(rb);
            rb.UpdateAABB();
            f_quadtree.Remove(rb, rb.ColliderData.GlobalAABB);
        }

        #endregion

        #region [Visuals]

        public override void Draw(UnityEngine.Vector2 offset) {
            f_quadtree.Draw(offset);
        }

        public override void Render() {
            base.Render();

            EditorGUILayout.LabelField("QT Nodes:", SuperPooler.Instance.GetPooler<QuadTree>().Size + "");
            EditorGUILayout.LabelField("QT Entries:", f_quadtree.Entries + "");
        }

        public override void UpdateRenderData() {
            base.UpdateRenderData();

            PrintData["Nodes"] = SuperPooler.Instance.GetPooler<QuadTree>().Size;
            PrintData["Entries"] = f_quadtree.Entries;
            PrintData["EmptyCells"] = QuadTree.EmptyCells;
        }

        #endregion
    }

}