using System;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        Type gettype = obj.GetType();
        if (gettype == typeof(int))
            return true;
        return false;
    }
}