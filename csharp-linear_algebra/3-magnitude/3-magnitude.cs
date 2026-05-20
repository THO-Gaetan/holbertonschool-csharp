using System;

/// <summary>Class Vector</summary>
class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
            return -1;
        double sum = 0;
        foreach (double num in vector)
            sum += Math.Pow(num, 2);
        return Math.Round(Math.Sqrt(sum), 2);
    }
}