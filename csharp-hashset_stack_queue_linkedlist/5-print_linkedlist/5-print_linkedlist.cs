using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            return null;
        }
        LinkedList<int> linkedList = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            linkedList.AddLast(i);
        }
        foreach (int num in linkedList)
        {
            Console.WriteLine(num);
        }
        return linkedList;
    }  
}