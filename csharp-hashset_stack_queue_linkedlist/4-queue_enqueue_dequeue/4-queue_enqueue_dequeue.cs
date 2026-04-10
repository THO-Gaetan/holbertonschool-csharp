using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print number of items
        Console.WriteLine($"Number of items: {aQueue.Count}");
        
        // Print first item or if empty
        if (aQueue.Count > 0)
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }
        
        // Add new item
        aQueue.Enqueue(newItem);
        
        // Check if contains search
        Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");
        
        // If contains search, remove all items up to and including search
        if (aQueue.Contains(search))
        {
            while (aQueue.Count > 0)
            {
                string item = aQueue.Dequeue();
                if (item == search)
                    break;
            }
        }
        
        return aQueue;
    }
}