using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1)
        || (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3))
            return new double[,] { { -1 } };
        
        double cos = Math.Round(Math.Cos(angle), 10);
        double sin = Math.Round(Math.Sin(angle), 10);
        double[,] rotation = {
            { cos, -sin },
            { sin,  cos }
        };

        int size = matrix.GetLength(0);
        int inner = rotation.GetLength(1);
        double[,] result = new double[size,size];

        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
            {
                if (j == 0) {
                    result[i, 0] += matrix[i, j] * cos;
                    result[i, 1] += matrix[i, j] * sin;
                }
                else  {
                    result[i, 0] += matrix[i, j] * -sin;
                    result[i, 1] += matrix[i, j] * cos;
                }
            }
        
        for (int i = 0; i  < size; i++)
            for (int j = 0; j < size; j++)
                result[i, j] = Math.Round(result[i, j], 2);
        return result;
    }
}