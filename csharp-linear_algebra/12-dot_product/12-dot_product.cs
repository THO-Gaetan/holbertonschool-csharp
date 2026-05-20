using System;

class VectorMath
{
    public static double DotProduct(double[] vectorA, double[] vectorB)
    {
        if (vectorA.Length != vectorB.Length && vectorA.length != 2 && vectorA.Length != 3)
            return new double[] { -1 };
        int result = 0;
        for (int i = 0; i < vectorA.Length; i++)
            result += vectorA[i] * vectorB[i];
        return result;
    }
}