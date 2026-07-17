using System;

class Player
{
    private string name;
    private float hp;
    private float maxHp;

    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            damage = 0f;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            heal = 0f;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }
    
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
        {
            hp = 0f;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue *= 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue *= 1.5f;
            default:
                return baseValue;
        }
    }
}

/// <summary>
/// Modifier enum
/// </summary>
public enum Modifier
{
    /// <summary> Weak modifier</summary>
    Weak,
    /// <summary> Base modifier</summary>
    Base,
    /// <summary> Strong modifier</summary>
    Strong
}

public delegate float CalculateModifier(float baseValue, Modifier modifier);