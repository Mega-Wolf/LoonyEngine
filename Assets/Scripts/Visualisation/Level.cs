using System.Collections.Generic;
using UnityEngine;

namespace LoonyEngine {

    public class Level : MBSingleton<Level> {

        #region [Consts]

        private Position MAX_SIZE = new Position(200, 100);

        #endregion

        #region [MemberFields]

        [SerializeField]
        private AnimationCurve f_size = new AnimationCurve(new Keyframe[] { new Keyframe(0, 0.5f), new Keyframe(1, 2) });

        [SerializeField]
        private AnimationCurve f_velocity = new AnimationCurve(new Keyframe[] { new Keyframe(0, 0.5f), new Keyframe(1, 10) });

        [SerializeField]
        private AnimationCurve f_startX = new AnimationCurve(new Keyframe[] { new Keyframe(0, 0), new Keyframe(1, 1) });

        [SerializeField]
        private AnimationCurve f_startY = new AnimationCurve(new Keyframe[] { new Keyframe(0, 0), new Keyframe(1, 1) });

        [SerializeField]
        private AnimationCurve f_number = new AnimationCurve(new Keyframe[] { new Keyframe(0, 100), new Keyframe(1, 100) });

        #endregion

        #region [FinalVariables]

        GameObject f_root;
        Transform2D f_rootTransform;

        HashSet<Rigidbody> f_rbs = new HashSet<Rigidbody>();
        HashSet<Rigidbody> f_dynamics = new HashSet<Rigidbody>();

        #endregion

        #region [Properties]

        public GameObject Root { get { return f_root; } }
        public HashSet<Rigidbody> Rigidbodies { get { return f_rbs; } }

        #endregion

        #region [Init]

        private void Start() {
            f_rootTransform = new Transform2D(null);
            f_root = new GameObject(f_rootTransform);

            ICollider2D aabbDummyCollider = new AABB(new Position(-1, -1), new Position(1, 1));

            // Create a border of AABBs
            {
                for (int x = 0; x <= 100; ++x) {
                    for (int y = 0; y < 2; ++y) {
                        Transform2D subT = new Transform2D(f_rootTransform);
                        subT.Position = new Position(x * 2, y * 50 * 2);
                        GameObject subGO = new GameObject(subT);
                        Rigidbody rb = new Rigidbody(subGO,
                            new DynamicData(Velocity.zero, Acceleration.zero),
                            new ObjectData(new PhysicsMaterial(), new Mass(1)),
                            new ColliderData(aabbDummyCollider, false, subT));
                        subGO.AddComponent(rb);
                        f_rbs.Add(rb);
                    }
                }

                for (int y = 1; y < 50; ++y) {
                    for (int x = 0; x < 2; ++x) {
                        Transform2D subT = new Transform2D(f_rootTransform);
                        subT.Position = new Position(x * 100 * 2, y * 2);
                        GameObject subGO = new GameObject(subT);
                        Rigidbody rb = new Rigidbody(subGO,
                            new DynamicData(Velocity.zero, Acceleration.zero),
                            new ObjectData(new PhysicsMaterial(), new Mass(1)),
                            new ColliderData(aabbDummyCollider, false, subT));
                        subGO.AddComponent(rb);
                        f_rbs.Add(rb);
                    }
                }

            }
        }

        private void FixedUpdate() {
            int finalNumber = (int)f_number.Evaluate(UnityEngine.Time.time);

            ICollider2D circleDummyCollider = new Circle(new PositionMagnitude(1));

            while (finalNumber > f_dynamics.Count) {
                int i = 0;
                float size = f_size.Evaluate(Random.value);
                float velocity = f_velocity.Evaluate(Random.value);

                Position position = new Position(MAX_SIZE.x.Float * f_startX.Evaluate(Random.value), MAX_SIZE.y.Float * f_startY.Evaluate(Random.value));
                position = TemporaryHelperFunctions.ComponentWiseClamp(position, Position.zero + new Position(size / 2, size / 2), MAX_SIZE - new Position(size / 2, size / 2));

                AABB propRect = new AABB(position - size * Position.one, position + size * Position.one);

                bool works = true;
                foreach (Rigidbody rigidbody in f_rbs) {
                    if (Intersections.DoIntersectAABBAABB(rigidbody.ColliderData.AABB, propRect)) {
                        works = false;
                        break;
                    }
                }
                if (!works) {
                    continue;
                }

                Transform2D subT = new Transform2D(f_rootTransform);
                subT.Position = new Position((propRect.Right + propRect.Left).Float / 2, (propRect.Top + propRect.Bottom).Float / 2);
                subT.Scale = size;
                GameObject subGO = new GameObject(subT);
                Rigidbody rb = new Rigidbody(subGO,
                    new DynamicData(new Velocity(velocity * Random.insideUnitCircle), Acceleration.zero),
                    new ObjectData(new PhysicsMaterial(), new Mass(1)),
                    new ColliderData(circleDummyCollider, false, subT));
                subGO.AddComponent(rb);
                f_rbs.Add(rb);
                f_dynamics.Add(rb);

                ++i;
            }

            while (finalNumber < f_dynamics.Count) {
                int number = Random.Range(0, f_dynamics.Count);
                int i = 0;
                foreach (Rigidbody rb in f_dynamics) {
                    if (i == number) {
                        f_dynamics.Remove(rb);
                        f_rbs.Remove(rb);
                        --i;
                        break;
                    }
                }
            }
        }

        #endregion

    }

}