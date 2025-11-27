namespace rpg
{
    // This class is abstract because it should never be instanced
    internal abstract class Entity
    {
        public float Hp {get;set;}
        public float Atk {get;set;}
        
        public Entity(float hp, float atk)
        {
            Hp = hp;
            Atk = atk;
        }
    }
}