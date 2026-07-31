using System;
/// <summary>
/// Represents a generic queue data structure.
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    public Type CheckType()
    {
        return typeof(T);
    }
}
