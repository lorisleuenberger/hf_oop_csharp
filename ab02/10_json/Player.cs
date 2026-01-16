using System.Reflection.Metadata.Ecma335;

internal class Player
{
    private readonly string? name;
    private int health;
    private decimal attack;
    private decimal bonusDamage;
    
    public Player(string name, int health, decimal attack, decimal bonusDamage)
    {
        this.name = name;
        this.health = health;
        this.attack = attack;
        this.bonusDamage = bonusDamage;
    }

    public string? Name
    {
        get
        {
            return name;
        }
    }
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            if(value > 0)
            {
                health = value;
            } else
            {
                Console.WriteLine("Health needs to be a positive number.");
            }
        }
    }
    public decimal Attack
    {
        get
        {
            return attack + bonusDamage;
        }
        set
        {
            if(value > 0)
            {
                attack = value;
            } else
            {
                Console.WriteLine("Attack needs to be a positive number.");
            }
        }
    }

    public decimal BonusDamage
    {
        get
        {
            return bonusDamage;
        }
        set
        {
            if(value > 0)
            {
                bonusDamage = value;
            } else
            {
                Console.WriteLine("BonusDamage needs to be a positive number.");
            }
        }
    }
}