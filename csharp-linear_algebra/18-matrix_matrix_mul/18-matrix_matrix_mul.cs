using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] { { -1 } };
        int rows = matrix1.GetLength(0);
        int cols = matrix2.GetLength(1);
        int inner = matrix1.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                for (int k = 0; k < inner; k++)
                    result[i,j] += matrix1[i, k] * matrix2[k, j];
        return result;
    }
}