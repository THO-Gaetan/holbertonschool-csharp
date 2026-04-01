using System;
using ListInt = System.Collections.Generic.List<int>;

class List
{
    public static int MaxInteger(ListInt myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int max = myList[0];
        for (int i = 1; i < myList.Count; i++)
        {
            if (myList[i] > max)
                max = myList[i];
        }
        return max;
    }
}