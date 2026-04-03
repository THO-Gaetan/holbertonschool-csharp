using System;
using DictStrInt = System.Collections.Generic.Dictionary<string, int>;

class Dictionary
{
    public static DictStrInt MultiplyBy2(DictStrInt myDict)
    {
        DictStrInt newDict = new DictStrInt();
        foreach (var kvp in myDict)
        {
            newDict[kvp.Key] = kvp.Value * 2;
        }
        return newDict;
    }
}