internal class Enemy
{
    private string? type;
    private int health;
    private decimal attack;

    public string? Type
    {
        get
        {
            return type;
        }
        set
        {
            type = value;
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
            return attack;
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
}