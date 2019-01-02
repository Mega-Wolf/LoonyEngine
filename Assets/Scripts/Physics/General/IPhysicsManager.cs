using System.Collections.Generic;

namespace LoonyEngine {

    public interface IPhysicsManager {

        #region [Updates]

        void Simulate();

        #endregion

        #region [PublicMethods]

        void AddPhysicsComponent(Rigidbody rb);

        void RemovePhysicsComponent(Rigidbody rb);

        #endregion

    }

}