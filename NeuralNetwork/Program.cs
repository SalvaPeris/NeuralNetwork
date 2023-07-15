using NeuralNetwork;
using NeuralNetwork.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        var neuralNet = new NeuralNet(1, 3);

        Console.WriteLine(" 1.Synaptic weights before training:");
        Matrix.Print(neuralNet.SynapsesMatrix);

        var trainingInputs = new double[,] { { 0, 0, 1 }, { 1, 1, 1 }, { 1, 0, 1 }, { 0, 1, 1 } };
        var trainingOutputs = Matrix.Transpose(new double[,] { { 0, 1, 1, 0 } });

        neuralNet.Train(trainingInputs, trainingOutputs, 10000);

        Console.WriteLine("\n 2.Synaptic weights after training:");
        Matrix.Print(neuralNet.SynapsesMatrix);

        var output = neuralNet.GetOutput(new double[,] { { 1, 1, 0 } });
        Console.WriteLine("\n 3.New problem [1, 1, 0]:");
        Matrix.Print(output);

        Console.Read();
    }
}