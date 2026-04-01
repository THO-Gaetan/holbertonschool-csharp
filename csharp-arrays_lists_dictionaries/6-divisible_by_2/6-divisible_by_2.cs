using System;
using ListInt = System.Collections.Generic.List<int>;
using ListBool = System.Collections.Generic.List<bool>;

class List
{
    public static ListBool DivisibleBy2(ListInt myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return new ListBool();
        }
        ListBool result = new ListBool();
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
                result.Add(true);
            else
                result.Add(false);
        }
        return result;
    }
}