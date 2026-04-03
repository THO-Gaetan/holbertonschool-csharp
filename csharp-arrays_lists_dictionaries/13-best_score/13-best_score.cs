using System;
using DictStrInt = System.Collections.Generic.Dictionary<string, int>;

class Dictionary
{
    public static string BestScore(DictStrInt myList)
    {
        if (myList.Count == 0)
            return null;

        string bestStudent = null;
        int bestScore = int.MinValue;

        foreach (var kvp in myList)
        {
            if (kvp.Value > bestScore)
            {
                bestScore = kvp.Value;
                bestStudent = kvp.Key;
            }
        }

        return bestStudent;
    }
}