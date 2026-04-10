using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        foreach (int num in myList)
        {
            sum += num;
        }
        return sum;
    }
}