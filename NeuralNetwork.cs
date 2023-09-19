using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyNeuralNetwork
{
    public class NeuralNetwork
    {
        int inputNodes;
        int hiddenNodes;
        int outputNodes;

        double[,] weightsInputToHidden;
        double[,] weightsHiddenToOutput;

        double learningRate; 

        public NeuralNetwork(int countInput, int countHidden, int countOutput, double learningRate)
        {
            inputNodes = countInput; 
            hiddenNodes = countHidden; 
            outputNodes = countOutput;
            this.learningRate = learningRate;


            weightsInputToHidden = new double[hiddenNodes,inputNodes];
            weightsHiddenToOutput = new double[outputNodes, hiddenNodes];

            Array.RandomValues(weightsInputToHidden);
            Array.RandomValues(weightsHiddenToOutput);
        }
        public NeuralNetwork(int countOutput, double learningRate)
        {
            inputNodes = 784;
            hiddenNodes = 80;
            outputNodes = countOutput;
            this.learningRate = learningRate;
            Deserialize();
        }

        public double[,] Predict(double[] inputNumberMas)
        {
            double[,] inputs = new double[inputNumberMas.Length, 1];
            for (int i = 0; i < inputNumberMas.Length; i++)
            {
                inputs[i, 0] = inputNumberMas[i];
            }
            double[,] hiddenInputs = Array.Multiply(weightsInputToHidden, inputs);
            double[,] hiddenOutputs = SigmoidForArray(hiddenInputs);

            double[,] finalInputs = Array.Multiply(weightsHiddenToOutput, hiddenOutputs);
            double[,] finalOutputs = SigmoidForArray(finalInputs);

            return finalOutputs;
        }

        public void Train(double[] inputNumberMas, double[] target)
        {
            double[,] inputs = new double[inputNumberMas.Length, 1];
            for (int i = 0; i < inputNumberMas.Length; i++)
            {
                inputs[i,0] = inputNumberMas[i];
            }
            double[,] targets = new double[target.Length, 1];
            for (int i = 0; i < target.Length; i++)
            {
                targets[i, 0] = target[i];
            }

            double[,] hiddenInputs = Array.Multiply(weightsInputToHidden, inputs);
            double[,] hiddenOutputs = SigmoidForArray(hiddenInputs);

            double[,] finalInputs = Array.Multiply(weightsHiddenToOutput, hiddenOutputs);
            double[,] finalOutputs = SigmoidForArray(finalInputs);

            double[,] outputErrors = Array.Dif(targets,finalOutputs);

            double[,] hiddenErrors = Array.Multiply(Array.InvertArray(weightsHiddenToOutput), outputErrors);

            weightsHiddenToOutput = Array.Sum(weightsHiddenToOutput, Array.MultiplyConst(Array.Multiply(Array.MultiplyElements(Array.MultiplyElements(outputErrors,finalOutputs),
                Array.DifConst(1.0,finalOutputs)),Array.InvertArray(hiddenOutputs)),learningRate));

            weightsInputToHidden = Array.Sum(weightsInputToHidden, Array.MultiplyConst(Array.Multiply(Array.MultiplyElements(Array.MultiplyElements(hiddenErrors, hiddenOutputs),
                Array.DifConst(1.0, hiddenOutputs)), Array.InvertArray(inputs)), learningRate));
        }

        private double[,] SigmoidForArray(double[,] inputArray)
        {
            double[,] resultArray = new double[inputArray.GetLength(0), inputArray.GetLength(1)];
            for (int i = 0; i < inputArray.GetLength(0); i++)
                for (int j = 0; j < inputArray.GetLength(1); j++)
                    resultArray[i, j] = Sigmoid(inputArray[i, j]);
            return resultArray;
        }

        private double Sigmoid(double x) 
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }
        
        public void Serialize()
        {
            using (Stream stream = File.Open( Path.Combine(Directory.GetCurrentDirectory(), "weightsHiddenToOutput.dat") , FileMode.Create))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, weightsHiddenToOutput);
            }
            using (Stream stream = File.Open(Path.Combine(Directory.GetCurrentDirectory(), "weightsInputToHidden.dat"), FileMode.Create))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, weightsInputToHidden);
            }
        }
        public void Deserialize()
        {
            using (Stream stream = File.Open(Path.Combine(Directory.GetCurrentDirectory(), "weightsHiddenToOutput.dat"), FileMode.Open))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                weightsHiddenToOutput = (double[,])bformatter.Deserialize(stream);
            }
            using (Stream stream = File.Open(Path.Combine(Directory.GetCurrentDirectory(), "weightsInputToHidden.dat"), FileMode.Open))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                weightsInputToHidden = (double[,])bformatter.Deserialize(stream);
            }
        }
    }
}
