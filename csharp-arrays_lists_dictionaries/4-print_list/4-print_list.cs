using System;
using ListInt = System.Collections.Generic.List<int>;

class List
{
    public static ListInt CreatePrint(int size)
    {
        ListInt myList = new ListInt();
        if (size <= 0)
        {
            Console.WriteLine();
            return myList;
        }
        for (int i = 0; i < size; i++)
        {
            myList.Add(i);
            if (i == size - 1)
                Console.WriteLine(myList[i]);
            else
                Console.Write(myList[i] + " ");
        }
        return myList;
    }
}