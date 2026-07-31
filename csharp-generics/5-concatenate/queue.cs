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
            count = -1;
            return default(T);
        }
        return head.value;
    }

    public T Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
        return head.value;
    }

    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(string);
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate is for a queue of strings or chars only");
            return default(string);
        }
        string result = head.value.ToString();
        Node current = head.next;
        while (current != null)
        {
            if (typeof(T) == typeof(string))
                result = result.ToString() + " " + current.value.ToString();
            else
            result = result.ToString() + current.value.ToString();
            current = current.next;
        }
        return result;
    }

    public int Count()
    {
        return count + 1;
    }
}   

