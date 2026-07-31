using System;

class Player
{
    private string name;
    private float hp;
    private float maxHp;
    private string status;

    public Player(string name = "Player", float maxHp = 100f, string status = "{name} is ready to go!")
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
        this.status = status;
        this.HPCheck += CheckStatus;
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
            HPCheck(this, new CurrentHPArgs(hp));
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
            HPCheck(this, new CurrentHPArgs(hp));
        }
        else
        {
            hp = newHp;
            HPCheck(this, new CurrentHPArgs(hp));
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

    private EventHandler<CurrentHPArgs> HPCheck;

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            Console.WriteLine($"{name} is in perfect health!");
        }
        else if (e.currentHp >= maxHp / 2f && e.currentHp < maxHp)
        {
            Console.WriteLine($"{name} is doing well!");
        }
        else if (e.currentHp >= maxHp / 4f && e.currentHp < maxHp / 2f)
        {
            Console.WriteLine($"{name} isn't doing too great...");
        }
        else if (e.currentHp > 0f && e.currentHp < maxHp / 4f)
        {
            Console.WriteLine($"{name} needs help!");
        }
        else
        {
            Console.WriteLine($"{name} is knocked out!");
        }
    }
}

class CurrentHPArgs : EventArgs
{
    public float currentHp { get; private set;  }

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
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
/// <summary>
/// CalculateModifier delegate
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);