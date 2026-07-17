using System;

abstract class Base
{
    public string name { get; set; }
    override public string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }

    public interface IInteractive
    {
        void Interact();
    }

    public interface iBreakable
    {
        int durability { get; set; }
        void Break();
    }

    public interface ICollectable
    {
        bool isCollected { get; set; }
        void Collect();
    }
}

class TestObject : Base, Base.IInteractive, Base.iBreakable, Base.ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
        Console.WriteLine($"You interact with the {name}.");
    }

    public void Break()
    {
        if (durability > 0)
        {
            durability--;
            Console.WriteLine($"You hit the {name}. It now has {durability} durability.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }

    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You collect the {name}.");
        }
        else
        {
            Console.WriteLine($"The {name} has already been collected.");
        }
    }
}