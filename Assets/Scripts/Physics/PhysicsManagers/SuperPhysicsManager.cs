using System.Collections.Generic;

namespace LoonyEngine {
    class SuperPhysicsManager : MBSingleton<SuperPhysicsManager>, IPhysicsManager {

        #region [Consts]

        public readonly Time DELTA_TIME = new Time(1 / 50f);

        #endregion

        #region [PrivateVariables]

        private List<AbstractPhysicsManager> m_physicsManagers = new List<AbstractPhysicsManager>();
        private Dictionary<Rigidbody, List<Rigidbody>> m_rbMapping = new Dictionary<Rigidbody, List<Rigidbody>>();

        #endregion

        #region [Properties]

        public List<AbstractPhysicsManager> PhysicsManagers { get { return m_physicsManagers; } }

        #endregion

        #region [Init]

        protected override void Awake() {
            base.Awake();

            AbstractPhysicsManager pm = new StupidPhysicsManager();
            m_physicsManagers.Add(pm);
        }

        #endregion

        #region [Updates]

        private void FixedUpdate() {
            Level.Instance.NonUnityUpdate();
            Simulate();
            foreach (AbstractPhysicsManager pm in m_physicsManagers) {
                pm.UpdateRenderData();
            }
        }

        #endregion

        #region [Overrides]

        public void Simulate() {
            for (int i = 0; i < m_physicsManagers.Count; ++i) {
                m_physicsManagers[i].Simulate();
            }
        }

        // since every sub physics manager wants to have its own transform to change; they have to be cloned for every PM

        public void AddPhysicsComponent(Rigidbody rb) {
            List<Rigidbody> rbList = new List<Rigidbody>();
            for (int i = 0; i < m_physicsManagers.Count; ++i) {
                GameObject go = rb.GameObject.CloneLeave();
                Rigidbody newRB = go.GetComponent<Rigidbody>();
                rbList.Add(newRB);
                m_physicsManagers[i].AddPhysicsComponent(newRB);
            }
            m_rbMapping[rb] = rbList;
        }

        public void RemovePhysicsComponent(Rigidbody rb) {
            List<Rigidbody> rbList = m_rbMapping[rb];
            m_rbMapping.Remove(rb);
            for (int i = 0; i < m_physicsManagers.Count; ++i) {
                Rigidbody clonedRB = rbList[i];
                m_physicsManagers[i].RemovePhysicsComponent(clonedRB);
                GameObject.Release(clonedRB.GameObject);
            }
            GameObject.Release(rb.GameObject);
        }

        #endregion

    }

}