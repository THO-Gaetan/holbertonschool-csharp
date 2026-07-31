using System;
/// <summary>
/// Represents a generic queue data structure.
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    public class Node
    {
        public T value { get; set; }
        public Node Next { get; set; }
        public Node head { get; set; }
        public Node tail { get; set; }
        public int count { get; set; }
        public Node(T Value)
        {
            value = Value;
            Next = null;
        }
    }
    public Type CheckType()
    {
        return typeof(T);
    }

    public Node Enqueue(T value)
    {
        if (head == null)
            head = new Node(value);
        else
        {
            Node newNode = new Node(value);
            tail.Next = newNode;
            count++;
        }
        return tail;
    }
}
