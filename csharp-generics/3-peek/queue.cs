using System;
/// <summary>
/// Represents a generic queue data structure.
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count = 0;
    public class Node
    {
        public T value = default(T);
        public Node next = null;
        public Node(T value)
        {
            this.value = value;
        }
    }
    public Type CheckType()
    {
        return typeof(T);
    }

    public Node Enqueue(T value)
    {
        if (head == null)
        {
            head = new Node(value);
            tail = head;
        }
        else
        {
            Node newNode = new Node(value);
            tail.next = newNode;
            tail = newNode;
            count++;
        }
        return tail;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node node = head;
        head = head.next;
        count--;
        return node.value;
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    public int Count()
    {
        return count + 1;
    }
}   
