using System.Collections.Generic;

namespace LoonyEngine {
    class SuperPhysicsManager : MBSingleton<SuperPhysicsManager>, IPhysicsManager {

        #region [Consts]

        public readonly Time DELTA_TIME = new Time(1 / 50f);

        #endregion

        #region [PrivateVariables]

        List<IPhysicsManager> m_physicsManagers;

        #endregion

        #region [Overrides]

        public void Simulate() {
            for (int i = 0; i < m_physicsManagers.Count; ++i) {
                m_physicsManagers[i].Simulate();
            }
        }

        public void AddPhysicsComponent(Rigidbody rb) {
            for (int i = 0; i < m_physicsManagers.Count; ++i) {
                m_physicsManagers[i].AddPhysicsComponent(rb);
            }
        }

        public void RemovePhysicsComponent(Rigidbody rb) {
            for (int i = 0; i < m_physicsManagers.Count; ++i) {
                m_physicsManagers[i].RemovePhysicsComponent(rb);
            }
        }

        #endregion

    }

}