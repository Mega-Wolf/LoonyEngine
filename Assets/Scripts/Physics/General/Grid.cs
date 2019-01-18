using System.Collections.Generic;
using UnityEngine;

namespace LoonyEngine {

    /// <summary>
    /// Spatial grid for holding Rigidbodies
    /// </summary>
    public class Grid {

        #region [Static]

        public static int s_elementCount = 0;
        public int Entries { get { return s_elementCount; } }

        private static int s_emptyNodes = 0;
        public static int EmptyCells { get { return s_emptyNodes; } }

        #endregion

        #region [FinalVariables]

        private PositionMagnitude f_cellSize;
        private Position f_offset;
        private Vector2Int f_cells;

        private List<Rigidbody>[,] f_cellRBs;

        #endregion

        #region [Properties]

        public int Count { get { return f_cells.x * f_cells.y; } }

        #endregion

        #region [Constructors]

        public Grid(PositionMagnitude cellSize, AABB aabb) {
            f_cellSize = cellSize;

            f_offset = aabb.BottomLeft;
            f_cells = Vector2Int.CeilToInt((aabb.TopRight - aabb.BottomLeft) / f_cellSize);

            f_cellRBs = new List<Rigidbody>[f_cells.y, f_cells.x];
            s_emptyNodes = f_cells.y * f_cells.x;

            for (int x = 0; x < f_cells.x; ++x) {
                for (int y = 0; y < f_cells.y; ++y) {
                    f_cellRBs[y, x] = new List<Rigidbody>();
                }
            }
        }

        public Grid(PositionMagnitude cellSize, Position offset, Vector2Int cells) {
            f_cellSize = cellSize;
            f_offset = offset;
            f_cells = cells;

            f_cellRBs = new List<Rigidbody>[cells.y, cells.x];
            s_emptyNodes = cells.y * cells.x;

            for (int x = 0; x < cells.x; ++x) {
                for (int y = 0; y < cells.y; ++y) {
                    f_cellRBs[y, x] = new List<Rigidbody>();
                }
            }
        }

        #endregion

        #region [PublicMethods]

        public void Insert(Rigidbody rb) {
            AABB aabb = rb.ColliderData.GlobalAABB;

            Vector2Int bottomLeft = GetCell(aabb.BottomLeft);
            Vector2Int topRight = GetCell(aabb.TopRight);

            for (int x = bottomLeft.x; x <= topRight.x; ++x) {
                for (int y = bottomLeft.y; y <= topRight.y; ++y) {
                    if (f_cellRBs[y, x].Count == 0) {
                        --s_emptyNodes;
                    }
                    f_cellRBs[y, x].Add(rb);
                    ++s_elementCount;
                }
            }
        }

        public void Remove(Rigidbody rb, AABB oldAABB) {
            Vector2Int bottomLeft = GetCell(oldAABB.BottomLeft);
            Vector2Int topRight = GetCell(oldAABB.TopRight);

            for (int x = bottomLeft.x; x <= topRight.x; ++x) {
                for (int y = bottomLeft.y; y <= topRight.y; ++y) {
                    f_cellRBs[y, x].Remove(rb);
                    --s_elementCount;
                    if (f_cellRBs[y, x].Count == 0) {
                        ++s_emptyNodes;
                    }
                }
            }
        }

        public void Move(Rigidbody rb, AABB oldAABB, AABB newAABB) {
            Vector2Int bottomLeftOld = GetCell(oldAABB.BottomLeft);
            Vector2Int topRightOld = GetCell(oldAABB.TopRight);

            Vector2Int bottomLeftNew = GetCell(newAABB.BottomLeft);
            Vector2Int topRightNew = GetCell(newAABB.TopRight);

            RectInt oldRect = new RectInt(bottomLeftOld, topRightOld - bottomLeftOld);
            RectInt newRect = new RectInt(bottomLeftNew, topRightNew - bottomLeftNew);

            // This might not really be efficient

            /* Remove when not in this cell anymore */
            {
                for (int x = bottomLeftOld.x; x <= topRightOld.x; ++x) {
                    for (int y = bottomLeftOld.y; y <= topRightOld.y; ++y) {
                        //if (!newRect.Contains(new Vector2Int(x, y))) {
                        if (!CorrectContains(newRect, new Vector2Int(x, y))) {
                            f_cellRBs[y, x].Remove(rb);
                            --s_elementCount;
                            if (f_cellRBs[y, x].Count == 0) {
                                ++s_emptyNodes;
                            }
                        }
                    }
                }
            }

            /* Add when newly added to this cell */
            {
                for (int x = bottomLeftNew.x; x <= topRightNew.x; ++x) {
                    for (int y = bottomLeftNew.y; y <= topRightNew.y; ++y) {
                        //if (!oldRect.Contains(new Vector2Int(x, y))) {
                        if (!CorrectContains(oldRect, new Vector2Int(x, y))) {
                            if (f_cellRBs[y, x].Count == 0) {
                                --s_emptyNodes;
                            }
                            f_cellRBs[y, x].Add(rb);
                            ++s_elementCount;
                        }
                    }
                }
            }
        }

        public IEnumerable<Rigidbody> Intersect(AABB aabb) {
            Vector2Int bottomLeft = GetCell(aabb.BottomLeft);
            Vector2Int topRight = GetCell(aabb.TopRight);

            for (int x = bottomLeft.x; x <= topRight.x; ++x) {
                for (int y = bottomLeft.y; y <= topRight.y; ++y) {
                    for (int i = 0; i < f_cellRBs[y, x].Count; ++i) {
                        yield return f_cellRBs[y, x][i];
                    }
                }
            }
        }

        public IEnumerable<Rigidbody> IntersectHigher(Rigidbody rb) {
            Vector2Int bottomLeft = GetCell(rb.ColliderData.GlobalAABB.BottomLeft);
            Vector2Int topRight = GetCell(rb.ColliderData.GlobalAABB.TopRight);

            for (int x = bottomLeft.x; x <= topRight.x; ++x) {
                for (int y = bottomLeft.y; y <= topRight.y; ++y) {
                    for (int i = 0; i < f_cellRBs[y, x].Count; ++i) {
                        if (f_cellRBs[y, x][i].ID > rb.ID) {
                            yield return f_cellRBs[y, x][i];
                        }
                    }
                }
            }
        }

        #endregion

        #region [PrivateMethods]

        private Vector2Int GetCell(Position position) {
            return Vector2Int.FloorToInt((position - f_offset) / f_cellSize);
        }

        private bool CorrectContains(RectInt rect, Vector2Int pos) {
            return
                rect.xMin <= pos.x &&
                rect.xMax >= pos.x &&
                rect.yMin <= pos.y &&
                rect.yMax >= pos.y;
        }

        #endregion

        public void Draw(Vector2 offset) {

            /* Draw Lines */
            {
                Gizmos.color = Color.black;
                for (int x = 0; x <= f_cells.x; ++x) {
                    Gizmos.DrawLine(offset + f_offset.Vector2 + new Vector2(x * f_cellSize.Float, 0), offset + f_offset.Vector2 + new Vector2(x * f_cellSize.Float, f_cells.y * f_cellSize.Float));
                }

                for (int y = 0; y <= f_cells.y; ++y) {
                    Gizmos.DrawLine(offset + f_offset.Vector2 + new Vector2(0, y * f_cellSize.Float), offset + f_offset.Vector2 + new Vector2(f_cells.x * f_cellSize.Float, y * f_cellSize.Float));
                }
            }

            /* Draw Connections */
            {
                Gizmos.color = Color.white;
                for (int x = 0; x < f_cells.x; ++x) {
                    for (int y = 0; y < f_cells.y; ++y) {
                        for (int i = 0; i < f_cellRBs[y, x].Count; ++i) {
                            Gizmos.DrawLine(offset + f_cellRBs[y, x][i].GameObject.Transform.Position.Vector2, offset + f_offset.Vector2 + f_cellSize.Float * new Vector2(x + 0.5f, y + 0.5f));
                        }
                    }
                }
            }
        }

    }

}