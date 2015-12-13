namespace Alkonost2.Models
{
    using ModelsInterfases;
    public abstract class Item : IItem
    {
        protected Item (double damage, double armor, double health, double movement, int critChance)
        {
            this.BonusHealth = health;
            this.BonusDamage = damage;
            this.BonusArmor = armor;
            this.BonusMovement = movement;
            this.BonusCritChance = critChance;
        }

        public double BonusDamage { get; private set; }
        public double BonusArmor { get; private set; }
        public double BonusHealth { get; private set; }
        public double BonusMovement { get; private set; }
        public int BonusCritChance{ get; private set; }
    }
}