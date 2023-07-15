using NeuralNetwork.Utils;

namespace NeuralNetwork
{
    public class NeuralNet
    {
        public int SynapseMatrixColumns { get; set; }
        public int SynapseMatrixLines { get; set; }
        public double[,] SynapsesMatrix { get; private set; }

        private Random _random;

        public NeuralNet(int synapseMatrixColumns, int synapseMatrixLines)
        {
            SynapseMatrixColumns = synapseMatrixColumns;
            SynapseMatrixLines = synapseMatrixLines;

            Init();
        }

        private void Init()
        {
            _random = new Random(1);
            InitializeSynapsesMatrix();
        }

        /// <summary>
        /// Initialize the matrix with the weight of the synapses
        /// </summary>
        private void InitializeSynapsesMatrix()
        {
            SynapsesMatrix = new double[SynapseMatrixLines, SynapseMatrixColumns];

            for (var i = 0; i < SynapseMatrixLines; i++)
                for (var j = 0; j < SynapseMatrixColumns; j++)
                    SynapsesMatrix[i, j] = (2 * _random.NextDouble()) - 1;
        }

        /// <summary>
        /// Get outputs given the inputs
        /// </summary>
        public double[,] GetOutput(double[,] inputMatrix)
        {
            var InputsAndWeights = Matrix.DotProduct(inputMatrix, SynapsesMatrix);
            return Sigmoid.Get(InputsAndWeights);
        }

        /// <summary>
        /// Train the neural network to achieve the output matrix values
        /// </summary>
        public void Train(double[,] trainInputMatrix, double[,] trainOutputMatrix, int interactions)
        {
            for (var i = 0; i < interactions; i++)
            {
                var output = GetOutput(trainInputMatrix);

                //error = target - currentOutput
                var error = Matrix.Substract(trainOutputMatrix, output);
                var curSigmoidDerivative = Sigmoid.GetDerivative(output);
                var errorSigmoidDerivative = Matrix.Product(error, curSigmoidDerivative);
                var adjustment = Matrix.DotProduct(Matrix.Transpose(trainInputMatrix), errorSigmoidDerivative);

                SynapsesMatrix = Matrix.Sum(SynapsesMatrix, adjustment);
            }
        }
    }
}
