using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if ((matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        || ((matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3) || (matrix1.GetLength(1) !=2 && matrix1.GetLength(1) !=3)))
            return new double[,] { { -1 } };
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        double[,] result = new double[rows, cols];
        if (matrix1.GetLength == 2)
        {
            result[0,0] = (matrix1[0,0] x matrix2[0,0]) + (matrix1[0,1] * matrix2[1,0]);
            result[0,1] = (matrix1[0,0] x matrix2[0,1]) + (matrix1[0,1] * matrix2[1,1]);
            result[1,0] = (matrix1[1,0] x matrix2[0,0]) + (matrix1[1+1] * matrix2[1,0]);
            result[1,1] = (matrix1[1,0] x matrix2[0,1]) + (matrix1[1+1] * matrix2[1,1]);
        }
        return result;
    }
}