using System;
using DictStr = System.Collections.Generic.Dictionary<string, string>;

class Dictionary
{
    public static int NumberOfKeys(DictStr myDict)
    {
        if (myDict == null)
        {
            Console.WriteLine("Dictionary is empty");
            return 0;
        }
        int count = 0;
        foreach (var key in myDict.Keys)
        {
            count++;
        }
        return count;
    }
}