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

class Door : Base, Base.IInteractive
{
    public Door(string name)
    {
        this.name = name;
    }
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}