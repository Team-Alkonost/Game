using AlkonostXNAGame.AlkonostDataStructure.Interfaces;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{ 
    public abstract class Item : IItem
    {
        protected Item (float damage, float armor, float health, float movement, int critChance)
        {
            this.BonusHealth = health;
            this.BonusDamage = damage;
            this.BonusArmor = armor;
            this.BonusMovement = movement;
            this.BonusCritChance = critChance;
        }

        public float BonusDamage { get; private set; }
        public float BonusArmor { get; private set; }
        public float BonusHealth { get; private set; }
        public float BonusMovement { get; private set; }
        public int BonusCritChance{ get; private set; }
    }
}