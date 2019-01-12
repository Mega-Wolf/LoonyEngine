using System.Collections.Generic;
using UnityEngine;

namespace LoonyEngine {

    public class Level : MBSingleton<Level> {

        #region [MemberFields]

        [SerializeField]
        private float f_triggerProbability = 0.1f;

        [SerializeField]
        private Vector2Int f_levelSize = new Vector2Int(100, 50);

        [SerializeField]
        private AnimationCurve f_size = new AnimationCurve(new Keyframe[] { new Keyframe(0, 0.5f), new Keyframe(1, 2) });

        [SerializeField]
        private AnimationCurve f_velocity = new AnimationCurve(new Keyframe[] { new Keyframe(0, 0.5f), new Keyframe(1, 10) });

        [SerializeField]
        private AnimationCurve f_startX = new AnimationCurve(new Keyframe[] { new Keyframe(0, 0), new Keyframe(1, 1) });

        [SerializeField]
        private AnimationCurve f_startY = new AnimationCurve(new Keyframe[] { new Keyframe(0, 0), new Keyframe(1, 1) });

        [SerializeField]
        private AnimationCurve f_layers = new AnimationCurve(new Keyframe[] { new Keyframe(0, 1), new Keyframe(1, 5) });

        [SerializeField]
        private AnimationCurve f_number = new AnimationCurve(new Keyframe[] { new Keyframe(0, 100), new Keyframe(1, 100) });

        [SerializeField]
        private AnimationCurve f_additionalFluctuation = new AnimationCurve(new Keyframe[] { new Keyframe(0, 10), new Keyframe(1, 10) });

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
            f_rootTransform = Transform2D.New(null);
            f_root = GameObject.New(f_rootTransform);

            ICollider2D aabbDummyCollider = new AABB(new Position(-1, -1), new Position(1, 1));

            // Create a border of AABBs
            {
                // for (int x = 0; x <= f_levelSize.x; ++x) {
                //     for (int y = 0; y < 2; ++y) {
                //         Transform2D subT = Transform2D.New(f_rootTransform);
                //         subT.Position = new Position(x * 2, y * f_levelSize.y * 2);
                //         GameObject subGO = GameObject.New(subT);
                //         Rigidbody rb = Rigidbody.New(
                //             new DynamicData(Velocity.zero, Acceleration.zero),
                //             new ObjectData(new PhysicsMaterial(), new Mass(1)),
                //             new ColliderData(aabbDummyCollider, false, 0, subT));
                //         subGO.AddComponent(rb);
                //         AddRB(rb);
                //     }
                // }

                // for (int y = 1; y < f_levelSize.y; ++y) {
                //     for (int x = 0; x < 2; ++x) {
                //         Transform2D subT = Transform2D.New(f_rootTransform);
                //         subT.Position = new Position(x * f_levelSize.x * 2, y * 2);
                //         GameObject subGO = GameObject.New(subT);
                //         Rigidbody rb = Rigidbody.New(
                //             new DynamicData(Velocity.zero, Acceleration.zero),
                //             new ObjectData(new PhysicsMaterial(), new Mass(1)),
                //             new ColliderData(aabbDummyCollider, false, 0, subT));
                //         subGO.AddComponent(rb);
                //         AddRB(rb);
                //     }
                // }
            }
                    
        }

        #endregion

        #region [Updates]

        float currentChange = 0;

        public void NonUnityUpdate() {
            float timeValue = UnityEngine.Time.time;

            // Adding and removing due to the exact number having to change
            {
                int finalNumber = Mathf.RoundToInt(f_number.Evaluate(timeValue));

                while (finalNumber > f_dynamics.Count) {
                    TryGenerateCircle();
                }

                while (finalNumber < f_dynamics.Count) {
                    TryRemoveCircle();
                }
            }

            // Removing and then adding to the the additional fluctuation
            {
                float changeRate = f_additionalFluctuation.Evaluate(timeValue);
                float changeValue = changeRate * SuperPhysicsManager.Instance.DELTA_TIME.Float;

                currentChange += changeValue;

                int amount = (int)currentChange;
                currentChange -= amount;

                int finalNumber = f_dynamics.Count;

                for (int i = 0; i < amount; ++i) {
                    TryRemoveCircle();
                }


                while (f_dynamics.Count < finalNumber) {
                    TryGenerateCircle();
                }
            }

        }

        #endregion

        #region [PrivateMethods]

        private void TryGenerateCircle() {
            ICollider2D circleDummyCollider = new Circle(new PositionMagnitude(1));

            float size = f_size.Evaluate(Random.value);
            float velocity = f_velocity.Evaluate(Random.value);
            int layer = Mathf.RoundToInt(f_layers.Evaluate(Random.value));
            bool isTrigger = Random.value < f_triggerProbability;

            Position position = new Position(2 * f_levelSize.x * f_startX.Evaluate(Random.value), 2 * f_levelSize.y * f_startY.Evaluate(Random.value));
            position = TemporaryHelperFunctions.ComponentWiseClamp(position, Position.zero + new Position(size / 2, size / 2), 2 * new Position(f_levelSize) - new Position(size / 2, size / 2));

            AABB propRect = new AABB(position - size * Position.one, position + size * Position.one);

            bool works = true;
            foreach (Rigidbody rigidbody in f_rbs) {
                if (
                    SuperPhysicsManager.Instance.PhysicsMatrix.DoCollide(rigidbody.ColliderData.LayerNumber, layer) &&
                    Intersections.DoIntersectAABBAABB(rigidbody.ColliderData.GlobalAABB, propRect)) {
                    works = false;
                    break;
                }
            }
            if (!works) {
                return;
            }

            Transform2D subT = Transform2D.New(f_rootTransform);
            subT.Position = new Position((propRect.Right + propRect.Left).Float / 2, (propRect.Top + propRect.Bottom).Float / 2);
            subT.Scale = size;
            GameObject subGO = GameObject.New(subT);
            Rigidbody rb = Rigidbody.New(
                new DynamicData(new Velocity(velocity * Random.insideUnitCircle), Acceleration.zero),
                new ObjectData(new PhysicsMaterial(), new Mass(1)),
                new ColliderData(circleDummyCollider, isTrigger, layer, subT));
            subGO.AddComponent(rb);
            AddRB(rb);
            f_dynamics.Add(rb);
        }

        private void TryRemoveCircle() {
            int number = Random.Range(0, f_dynamics.Count);
            int i = 0;
            foreach (Rigidbody rb in f_dynamics) {
                if (i == number) {
                    f_dynamics.Remove(rb);
                    RemoveRB(rb);
                    break;
                }
                ++i;
            }
        }

        private void AddRB(Rigidbody rb) {
            f_rbs.Add(rb);
            SuperPhysicsManager.Instance.AddPhysicsComponent(rb);
        }

        private void RemoveRB(Rigidbody rb) {
            f_rbs.Remove(rb);
            SuperPhysicsManager.Instance.RemovePhysicsComponent(rb);
        }

        #endregion

    }

}