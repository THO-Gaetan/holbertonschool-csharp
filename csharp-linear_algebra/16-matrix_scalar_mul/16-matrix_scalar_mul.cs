using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if ((matrix.GetLength(0) != 2 && matrix.GetLength(0) !=3)
        || (matrix.GetLength(1) != 2 && matrix.GetLength(1) !=3))
            return new double[,] { -1 };
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[rows, cols];
        for (i = 0; i < rows; i++)
            for (j = 0; j < cols; j++)
                result[i,j] = matrix[i,j] * scalar;
        return result;
    }
}