using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace LoonyEngine {

    /// <summary>
    /// QuadTree class which holds Rigidbodies
    /// </summary>
    public class QuadTree {

        #region [Static]

        public static int s_elementCount = 0;
        public int Entries { get { return s_elementCount; } }

        private static Pooler<QuadTree> s_pooler = SuperPooler.Instance.GetPooler<QuadTree>();

        public static void Release(QuadTree quadtree) {
            s_pooler.ReleaseInstance(quadtree);
        }

        #endregion

        #region [Consts]

        private static int MAX_ELEMENTS = 4;
        private static int MAX_DEPTH = 8;

        #endregion

        #region [FinalVariables]

        private AABB f_aabb;
        private int f_depth;
        private List<Rigidbody> f_elements = new List<Rigidbody>(MAX_ELEMENTS);

        #endregion

        #region [PrivateVariables]

        private QuadTree[] m_children;

        #endregion

        #region [Constructors]

        public static QuadTree New(AABB aabb, int depth) {
            QuadTree qt = s_pooler.GetInstance();
            qt.Init(aabb, depth);
            return qt;
        }

        #endregion

        #region [Init]

        private void Init(AABB aabb, int depth) {
            f_aabb = aabb;
            f_depth = depth;
        }

        #endregion

        #region [PublicMethods]

        public void Insert(Rigidbody rb) {
            if (m_children != null) {
                for (int i = 0; i < 4; ++i) {
                    if (Intersections.DoIntersectAABBAABB(rb.ColliderData.GlobalAABB, m_children[i].f_aabb)) {
                        m_children[i].Insert(rb);
                    }
                }
            } else if (f_depth < MAX_DEPTH && f_elements.Count == MAX_ELEMENTS) {
                // This means I have to split the QT
                m_children = new QuadTree[4];

                m_children[0] = QuadTree.New(f_aabb.BottomLeftAABB, f_depth + 1);
                m_children[1] = QuadTree.New(f_aabb.BottomRightAABB, f_depth + 1);
                m_children[2] = QuadTree.New(f_aabb.TopLeftAABB, f_depth + 1);
                m_children[3] = QuadTree.New(f_aabb.TopRightAABB, f_depth + 1);

                for (int i = 0; i < f_elements.Count; ++i) {
                    Insert(f_elements[i]);
                }
                Insert(rb);
                f_elements.Clear();
                s_elementCount -= MAX_ELEMENTS;
            } else {
                f_elements.Add(rb);
                ++s_elementCount;
            }
        }

        public void Remove(Rigidbody rb, AABB oldAABB) {
            if (m_children == null) {
                f_elements.Remove(rb);
                --s_elementCount;
            } else {
                for (int i = 0; i < 4; ++i) {
                    if (Intersections.DoIntersectAABBAABB(oldAABB, m_children[i].f_aabb)) {
                        m_children[i].Remove(rb, oldAABB);
                    }
                }

                /* Check if all children are empty now and therefore delete them again */
                {
                    for (int i = 0; i < 4; ++i) {
                        if (!(m_children[i].f_elements.Count == 0 && m_children[i].m_children == null)) {
                            return;
                        }
                    }
                    for (int i = 0; i < 4; ++i) {
                        Release(m_children[i]);
                    }
                    m_children = null;
                }

            }
        }

        public void Move(Rigidbody rigidbody, AABB oldAABB, AABB newAABB) {
            if (m_children == null) {

                bool intersectOld = (Intersections.DoIntersectAABBAABB(oldAABB, f_aabb));
                bool intersectNew = (Intersections.DoIntersectAABBAABB(newAABB, f_aabb));

                if (intersectOld && !intersectNew) {
                    Remove(rigidbody, oldAABB);
                } else if (!intersectOld && intersectNew) {
                    Insert(rigidbody);
                }
            } else {
                for (int i = 0; i < 4; ++i) {
                    bool intersectOld = (Intersections.DoIntersectAABBAABB(oldAABB, m_children[i].f_aabb));
                    bool intersectNew = (Intersections.DoIntersectAABBAABB(newAABB, m_children[i].f_aabb));

                    if (intersectOld && !intersectNew) {
                        m_children[i].Remove(rigidbody, oldAABB);
                    } else if (!intersectOld && intersectNew) {
                        m_children[i].Insert(rigidbody);
                    } else if (intersectOld && intersectNew /*&& !(oldAABB.ContainsCompletely(m_children[i].f_aabb) && newAABB.ContainsCompletely(m_children[i].f_aabb))*/) {
                        m_children[i].Move(rigidbody, oldAABB, newAABB);
                    }
                }
            }
        }

        /// <summary>
        /// Returns an Enumerable with intersecting rbs
        /// Normally, do not use this
        /// </summary>
        public IEnumerable<Rigidbody> IntersectAll(AABB aabb) {
            if (m_children == null) {
                foreach (Rigidbody innerRB in f_elements) {
                    yield return innerRB;
                }
            } else {
                for (int i = 0; i < 4; ++i) {
                    if (Intersections.DoIntersectAABBAABB(aabb, m_children[i].f_aabb)) {
                        foreach (Rigidbody innerRB in m_children[i].IntersectAll(aabb)) {
                            yield return innerRB;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Returns an Enumerable with intersecting rbs
        /// Only returns rbs with a higher ID than the given one; that way rbs don't collide with self or twice with something else
        /// </summary>
        public IEnumerable<Rigidbody> IntersectHigher(Rigidbody rb) {
            // normally I would only return the ones which passed the broad phase, or even do the narrow phase in here, but since I have to record that, I return everything in here

            if (m_children == null) {
                foreach (Rigidbody innerRB in f_elements) {
                    if (innerRB.ID > rb.ID) {
                        yield return innerRB;
                    }
                }
            } else {
                for (int i = 0; i < 4; ++i) {
                    if (Intersections.DoIntersectAABBAABB(rb.ColliderData.GlobalAABB, m_children[i].f_aabb)) {
                        foreach (Rigidbody innerRB in m_children[i].IntersectHigher(rb)) {
                            yield return innerRB;
                        }
                    }
                }
            }
        }

        #endregion

        public void Draw(Vector2 offset) {

            /* Draw QT lines */
            {
                if (m_children != null) {
                    for (int i = 0; i < 4; ++i) {
                        m_children[i].Draw(offset);
                    }

                    Gizmos.color = Color.black;
                    Gizmos.DrawLine(offset + new Vector2(f_aabb.Centre.x.Float, f_aabb.Bottom.Float), offset + new Vector2(f_aabb.Centre.x.Float, f_aabb.Top.Float));
                    Gizmos.DrawLine(offset + new Vector2(f_aabb.Left.Float, f_aabb.Centre.y.Float), offset + new Vector2(f_aabb.Right.Float, f_aabb.Centre.y.Float));
                }
            }

            /* Draw Connections */
            {
                Gizmos.color = Color.white;
                for (int i = 0; i < f_elements.Count; ++i) {
                    Gizmos.DrawLine(offset + f_aabb.Centre.Vector2, offset + f_elements[i].GameObject.Transform.Position.Vector2);
                }
            }

        }

    }
}