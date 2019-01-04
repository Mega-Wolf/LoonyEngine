using System.Collections.Generic;

namespace LoonyEngine {

    // This is kind of stupid, but this is the easiest way to track the data for the different PMs
    public abstract class AbstractPhysicsManager : IPhysicsManager {

        enum CheckState {
            BroadCheck,
            NarrowCheck
        }

        #region [Static]

        public static ulong CalcRBID(Rigidbody rb1, Rigidbody rb2) {
            if (rb1.ID < rb2.ID) {
                return (rb1.ID << 32) + rb2.ID;
            } else {
                return (rb1.ID << 32) + rb2.ID;
            }
        }

        #endregion

        #region [PrivateVariables]

        private HashSet<ulong> f_collisionsLastRound = new HashSet<ulong>();
        private HashSet<ulong> f_collisionsThisRound = new HashSet<ulong>();

        private Dictionary<ulong, CheckState> f_checkStates = new Dictionary<ulong, CheckState>();

        #endregion

        #region [ProtectedMethods]

        protected bool BroadPhase(Rigidbody rb1, Rigidbody rb2) {
            f_checkStates[CalcRBID(rb1, rb2)] = CheckState.BroadCheck;

            return Intersections.DoIntersectAABBAABB(rb1.ColliderData.GlobalAABB, rb2.ColliderData.GlobalAABB);
        }

        protected void NarrowPhase(Rigidbody rb1, Rigidbody rb2) {
            // TODO colelct this data
            // TODO: I have to know if this collision is new or not

            // If none of them are triggers, that means that the collision shall be resolved
            if (!rb1.ColliderData.IsTrigger && !rb2.ColliderData.IsTrigger) {
                //TODO; check directly for collision + resolve if possible (resolve only if moving towards each other)
                // pass collision to the event
            } else {
                // TODO only check if they are touching + calling trigger functions after that if any
                // pass collider to the event
            }



        }

        #endregion

        #region [Abstracts]

        public abstract void Simulate();

        public abstract void AddPhysicsComponent(Rigidbody rb);
        public abstract void RemovePhysicsComponent(Rigidbody rb);

        #endregion
    }

}