internal class Program
{
    private static void Main(string[] args)
    {
        Player player1 = new Player("John", 250, (decimal)20.0, 0);
        Player player2 = new Player("Jane", 140, (decimal)35.0, 0);

        Enemy orc = new Enemy { Type = "Orc", Health = 40, Attack = (decimal)10.0};
        Enemy griffin = new Enemy { Type = "Griffin", Health = 200, Attack = (decimal)15.0};
        Enemy darkMage = new Enemy { Type = "Dark Mage", Health = 30, Attack = (decimal)20.0};
        
        Item potion = new Item { Description = "Healing Potion", HealingHealth = 100, BonusDamage = 0};
        Item grilledMeat = new Item { Description = "Grilled Meat", HealingHealth = 10, BonusDamage = 30};
        Item whetstone = new Item { Description = "Whetstone", HealingHealth = 0, BonusDamage = 50};
        
        Level level1 = new Level
        { 
            Number = 1,
            Enemies = new List<Enemy> { orc, orc },
            Items = new List<Item> {grilledMeat}
        };
        Level level2 = new Level
        { 
            Number = 2,
            Enemies = new List<Enemy> { darkMage,  griffin},
            Items = new List<Item> {potion, whetstone}
        };
        Game game = new Game
        {
            Players = new List<Player> {player1, player2},
            Levels = new List<Level> {level1, level2}
        };
    }
}