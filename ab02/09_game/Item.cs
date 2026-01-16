internal class Item
{
    private string? description;
    private int healingHealth;
    private decimal bonusDamage;

    public string? Description { get => description; set => description = value; }
    public int HealingHealth { get => healingHealth; set => healingHealth = value; }
    public decimal BonusDamage { get => bonusDamage; set => bonusDamage = value; }
}