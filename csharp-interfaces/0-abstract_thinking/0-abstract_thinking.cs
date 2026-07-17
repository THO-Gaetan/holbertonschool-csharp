using System;

abstract class Base
{
    public string name { get; set; }
    override public string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}