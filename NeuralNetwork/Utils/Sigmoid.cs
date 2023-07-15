namespace NeuralNetwork.Utils
{
    public static class Sigmoid
    {
        /// <summary>
        /// Calculate the sigmoid of a value
        /// </summary>
        /// <returns></returns>
        public static double[,] Get(double[,] matrix)
        {

            int rowLength = matrix.GetLength(0);
            int columnLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
                for (int j = 0; j < columnLength; j++)
                {
                    var value = matrix[i, j];
                    matrix[i, j] = 1 / (1 + Math.Exp(value * -1));
                }
            return matrix;
        }

        /// <summary>
        /// Calculate the sigmoid derivative of a value
        /// </summary>
        /// <returns></returns>
        public static double[,] GetDerivative(double[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int columnLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
                for (int j = 0; j < columnLength; j++)
                {
                    var value = matrix[i, j];
                    matrix[i, j] = value * (1 - value);
                }
            return matrix;
        }
    }
}
