/// <summary>
/// Provides vector math operations for 2D and 3D vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Adds two vectors of the same size together component by component.
    /// </summary>
    /// <param name="vector1">The first vector, must be 2D or 3D.</param>
    /// <param name="vector2">The second vector, must be 2D or 3D.</param>
    /// <returns>
    /// A new vector that is the sum of two vector.
    /// Returns -1 if the vectors are different size or not 2D or 3D.
    /// </returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || (vector1.Length != 2 && vector1.Length != 3))
            return new double[] { -1 };
        double[] result = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }
        return result;
    }
}