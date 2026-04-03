using System;
using DictStr = System.Collections.Generic.Dictionary<string, string>;

class Dictionary
{
    public static DictStr AddKeyValue(DictStr myDict, string key, string value)
    {
        if (myDict.ContainsKey(key))
        {
            myDict[key] = value;
        }
        else
        {
            myDict.Add(key, value);
        }
        return myDict;
    }
}