using AlkonostXNAGame.AlkonostDataStructure.Interfaces;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{ 
    public abstract class Item : IItem
    {
        protected Item (int damage, int armor, int health, int movement, int critChance)
        {
            this.BonusHealth = health;
            this.BonusDamage = damage;
            this.BonusArmor = armor;
            this.BonusMovement = movement;
            this.BonusCritChance = critChance;
        }

        public int BonusDamage { get; private set; }
        public int BonusArmor { get; private set; }
        public int BonusHealth { get; private set; }
        public int BonusMovement { get; private set; }
        public int BonusCritChance{ get; private set; }
    }
}