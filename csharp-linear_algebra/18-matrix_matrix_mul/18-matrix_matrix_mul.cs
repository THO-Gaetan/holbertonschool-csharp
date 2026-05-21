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
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i,j] = (matrix1[i,0] * matrix2[0,j] + (matrix1[i,1] * matrix2[1,j]))
        return result;
    }
}