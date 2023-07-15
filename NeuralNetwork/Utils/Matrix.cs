namespace NeuralNetwork.Utils
{
    public class Matrix
    {
        /// <summary>
        /// Sum matrices
        /// </summary>
        /// <returns></returns>
        public static double[,] Sum(double[,] matrixA, double[,] matrixB)
        {
            var rowsA = matrixA.GetLength(0);
            var columnsA = matrixA.GetLength(1);

            var result = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < columnsA; j++)
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
            return result;
        }

        /// <summary>
        /// Subtract matrices
        /// </summary>
        /// <returns></returns>
        public static double[,] Substract(double[,] matrixA, double[,] matrixB)
        {
            var rowsA = matrixA.GetLength(0);
            var columnsA = matrixA.GetLength(1);

            var result = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < columnsA; j++)
                    result[i, j] = matrixA[i, j] - matrixB[i, j];
            return result;
        }

        /// <summary>
        /// Multiplication of a matrix
        /// </summary>
        /// <returns></returns>
        public static double[,] Product(double[,] matrixA, double[,] matrixB)
        {
            var rowsA = matrixA.GetLength(0);
            var columnsA = matrixA.GetLength(1);

            var result = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < columnsA; j++)
                    result[i, j] = matrixA[i, j] * matrixB[i, j];
            return result;
        }

        /// <summary>
        /// Dot Multiplication of a matrix
        /// </summary>
        /// <returns></returns>
        public static double[,] DotProduct(double[,] matrixA, double[,] matrixB)
        {
            var rowsA = matrixA.GetLength(0);
            var rowsB = matrixB.GetLength(0);
            var columnsB = matrixB.GetLength(1);

            var result = new double[rowsA, columnsB];

            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < columnsB; j++)
                    for (int k = 0; k < rowsB; k++)
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
            return result;
        }

        /// <summary>
        /// Transpose a matrix
        /// </summary>
        /// <returns></returns>
        public static double[,] Transpose(double[,] matrix)
        {
            int w = matrix.GetLength(0);
            int h = matrix.GetLength(1);

            double[,] result = new double[h, w];

            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                    result[j, i] = matrix[i, j];
            return result;
        }

        /// <summary>
        /// Print a matrix
        /// </summary>
        public static void Print(double[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int columnLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
                for (int j = 0; j < columnLength; j++)
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                Console.Write(Environment.NewLine);
        }
    }
}
