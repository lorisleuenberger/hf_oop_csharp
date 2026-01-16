internal class Level
{
    private int number;
    private List<Enemy> enemies;
    private List<Item> items;

    public int Number { get => number; set => number = value; }
    public List<Enemy> Enemies { get => enemies; set => enemies = value; }
    public List<Item> Items { get => items; set => items = value; }
}