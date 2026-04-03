using System;
using System.Linq;
using DictStr = System.Collections.Generic.Dictionary<string, string>;

class Dictionary
{
    public static void PrintSorted(DictStr myDict)
    {
        foreach (var kvp in myDict.OrderBy(kvp => kvp.Key))
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}