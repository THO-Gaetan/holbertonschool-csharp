using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set = new HashSet<int>(list1);
        List<int> common = new List<int>();

        foreach (int num in list2)
        {
            if (set.Contains(num))
            {
                common.Add(num);
            }
        }

        return common;
    }
}