namespace LoonyEngine{
    
    /// <summary>
    /// A very simple PhysicsMatrix
    /// Possibility to have a wrong matrix; inefficient; no setter
    /// </summary>
    public class PhysicsMatrix {

        #region [PrivateVariables]

        private bool[][] m_matrix;

        #endregion

        #region [Constructors]

        public PhysicsMatrix(bool[][] matrix) {
            // TODO; I would actually have to check that they are all the correct size and symmetric
            // also, they all have to have the correct size
            // also, [,] would be better
            m_matrix = matrix;
        }

        #endregion

        #region [PublicMethods]

        public bool DoCollide(int layerNumber1, int layerNumber2) {
            return m_matrix[layerNumber1][layerNumber2];
        }

        #endregion

    }

}