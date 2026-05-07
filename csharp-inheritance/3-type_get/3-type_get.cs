using System;
using System.Reflection;
using System.Collections.Generic;

class Obj
{
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();
        Console.WriteLine(type.Name + " Properties:");
        
        // Get all properties
        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo prop in properties)
        {
            Console.WriteLine(prop.Name);
        }
        
        Console.WriteLine(type.Name + " Methods:");
        // Get all methods
        MethodInfo[] methods = type.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}