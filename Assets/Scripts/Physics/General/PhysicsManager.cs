using System.Collections.Generic;

namespace LoonyEngine {

    public class PhysicsManager : UnityEngine.MonoBehaviour {

        #region [Consts]

        public Time DELTA_TIME = new Time(1 / 50f);

        #endregion

        #region [FinalVariables]

        private readonly List<Transform2D> f_transforms = new List<Transform2D>();
        private readonly List<Rigidbody> f_rbs = new List<Rigidbody>();

        #endregion

        #region [Updates]

        private void FixedUpdate() {
            // TODO: Chnage velocity by acceleration
            // TODO; How to handle multiple forces at the same time?

            // Move every Transform2D by its velocity
            for (int i = 0; i < f_transforms.Count; ++i) {
                f_transforms[i].Position += f_rbs[i].Velocity * DELTA_TIME;
            }
        }

        #endregion

        #region [PublicMethods]

        // add to collisions
        // add to triggers
        // etc.
        // making physics casts
        // making raycasts

        #endregion

    }

}