using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double det = (matrix[0, 0] * matrix[1, 1]) -
                     (matrix[0, 1] * matrix[1, 0]);

        if (det == 0)
            return new double[,] { { -1 } };

        double[,] result = {
            {  matrix[1, 1], -matrix[0, 1] },
            { -matrix[1, 0],  matrix[0, 0] }
        };

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                result[i, j] = Math.Round(result[i, j] / det, 2);

        return result;
    }
}