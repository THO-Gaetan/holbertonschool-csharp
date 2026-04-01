using System;
using ListInt = System.Collections.Generic.List<int>;

class List
{
    public static ListInt DeleteAt(ListInt myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index out of range");
            return myList;
        }
        myList.RemoveAt(index);
        return myList;
    }
}