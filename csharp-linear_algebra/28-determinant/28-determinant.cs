using System;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int size = matrix.GetLength(0);

        if (matrix.GetLength(0) != matrix.GetLength(1) || (size != 2 && size != 3))
            return -1;
        
        if (size == 2)
        {
            return (matrix[0,0] * matrix[1,1]) -
                   (matrix[0,1] * matrix[1,0]);
        }
        else
        {
            double result1 = matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]));
            double result2 = matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]));
            double result3 = matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]));

            return math.Round(result1 - result2 + result3, 2);
        }
    }
}