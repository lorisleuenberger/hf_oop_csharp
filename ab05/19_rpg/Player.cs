namespace rpg
{
    internal class Player: Entity
    {
        public int Potions {get;set;}
        public Player(float hp, float atk, int potions): base(hp, atk)
        {
            Potions = potions;
        }
    }
}