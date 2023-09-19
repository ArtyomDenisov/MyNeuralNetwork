using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeuralNetwork
{
    internal class Array
    {
        static Random random = new Random();

        static public double[,] RandomValues(double[,] array)
        {
            double[,] randomArray = array;
            for (int i = 0; i < randomArray.GetLength(0); i++)
                for (int j = 0; j < randomArray.GetLength(1); j++)
                    randomArray[i, j] = random.Next(0, 2) == 0 ? (random.NextDouble() + 0.1) * 0.6 : -((random.NextDouble() + 0.1) * 0.6);
            return randomArray;
        }

        static public double[,] Multiply(double[,] A, double[,] B)
        {
            int rowA = A.GetLength(0);
            int columnA = A.GetLength(1);
            int rowB = B.GetLength(0);
            int colunmB = B.GetLength(1);

            if (columnA != rowB)
            {
                throw new Exception("Матрицы не могут быть перемножены");
            }
            else
            {
                double temp = 0;
                double[,] resultArray = new double[rowA, colunmB];

                for (int i = 0; i < rowA; i++)
                {
                    for (int j = 0; j < colunmB; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < columnA; k++)
                        {
                            temp += A[i, k] * B[k, j];
                        }
                        resultArray[i, j] = temp;
                    }
                }
                return resultArray;
            }
        }
        static public double[,] MultiplyElements(double[,] A, double[,] B)
        {
            if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
                throw new ArgumentException("Матрицы имеют разные размерности");
            double[,] resultArray = new double[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    resultArray[i, j] = A[i, j] * B[i, j];

            return resultArray;
        }
        static public double[,] MultiplyConst(double[,] inputMatrix, double curConst)
        {

            double[,] resultArray = new double[inputMatrix.GetLength(0), inputMatrix.GetLength(1)];

            for (int i = 0; i < inputMatrix.GetLength(0); i++)
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                    resultArray[i, j] = inputMatrix[i, j] * curConst;
            return resultArray;
        }
        
        static public double[,] Sum(double[,] A, double[,] B)
        {
            if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
            {
                throw new ArgumentException("Сложение невозможно. Разная размерность");
            }
            double[,] resultArray = new double[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    resultArray[i, j] = A[i, j] + B[i,j];
            return resultArray;
        }
        static public double[,] Dif(double[,] A, double[,] B)
        {
            if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
            {
                throw new ArgumentException("Вычитание невозможно. Разная размерность");
            }
            double[,] resultArray = new double[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    resultArray[i, j] = A[i, j] - B[i, j];
            return resultArray;
        }
        static public double[,] DifConst(double curConst, double[,] inputMatrix)
        {
            double[,] resultArray = new double[inputMatrix.GetLength(0), inputMatrix.GetLength(1)];
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                    resultArray[i, j] = curConst - inputMatrix[i, j];
            return resultArray;
        }

        static public double[,] InvertArray(double[,] inputArray)
        {
            double[,] invertArray = new double[inputArray.GetLength(1), inputArray.GetLength(0)];
            for (int i = 0; i < inputArray.GetLength(1); i++)
                for (int j = 0; j < inputArray.GetLength(0); j++)
                    invertArray[i, j] = inputArray[j, i];
            return invertArray;
        }
    }
}
