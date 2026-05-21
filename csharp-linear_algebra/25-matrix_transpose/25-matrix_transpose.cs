using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return new double[,] {};

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] result = new double[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[j, i] = matrix[i, j];

        return result;
    }
}