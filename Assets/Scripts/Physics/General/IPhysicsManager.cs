using System.Collections.Generic;

namespace LoonyEngine {

    public interface IPhysicsManager {

        #region [Properties]

        #region [Properties]

        IEnumerable<Rigidbody> Rigidbodies { get ;}

        #endregion

        #endregion

        #region [Updates]

        void Simulate();

        #endregion

        #region [PublicMethods]

        void AddPhysicsComponent(Rigidbody rb);

        void RemovePhysicsComponent(Rigidbody rb);

        void ChangeLayer(Rigidbody rb, int oldLayerNumber, int newLayerNumber);

        void SetPhysicsMatrix(PhysicsMatrix physicsMatrix);

        #endregion

    }

}