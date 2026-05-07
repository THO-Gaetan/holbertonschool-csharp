using System;

class Shape
{
    public virtual int Area()
    {
        Throw new NotImplementedException("Area() is not implemented");
    }
}