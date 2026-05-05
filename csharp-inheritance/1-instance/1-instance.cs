using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        Type GetType = obj.GetType();
        if (GetType.IsArray)
            return true;
        return false;
    }
}