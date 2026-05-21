using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1) || (matrix.GetLength(0) != 2))
        || (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };

        double[,] shear = { { 1, 0 }, { 0, 1 } };
        if (direction == "x")
            shear[0, 1] = factor;
        else
            shear[1, 0] = factor;

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];
        
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                for (int k = 0; k < size; k++)
                    result[i, j] += matrix[i, k] * shear[k, j];

        return result;
    }
}