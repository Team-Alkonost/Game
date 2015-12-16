using System.Collections.Generic;
using AlkonostXNAGame.XNAData;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public partial class Player : Character
    {
        private const double DefautHealth = 100;
        private const double DefautDamage = 50;
        private const double DefautArmor = 10;
        private const double DefautMovement = 100;
        private const double MovementEffect = 0.05;        
        private HashSet<Item> inventory;

        public Player() 
            : base(DefautHealth, DefautDamage, DefautArmor, DefautMovement)
        {
            this.inventory = new HashSet<Item>();
        }

        public IEnumerable<Item> Inventory
        {
            get
            {
                return this.inventory;
            }
        }  
        
        public void AddItem(Item item)
        {
            inventory.Add(item);            
        }    

        public override double Hit()
        {
            double damage =  this.CalculateAttackPoints();
            return damage;
        }
        protected override double CalculateAttackPoints()
        {
            double sumOfDamageOfItems = 0;
            double finalDamage = 0;
            foreach (Item item in Inventory)
            {               
                sumOfDamageOfItems += item.BonusDamage + (item.BonusMovement * MovementEffect);
            }
            finalDamage += this.Damage + sumOfDamageOfItems;

            return finalDamage;            
        }

        public override double Defend()
        {
            double totalHealth = this.CalculateHealth();
            return totalHealth;
        }

        protected override double CalculateHealth()
        {
            double finalHealth = 0;
            double itemHealthBonus = 0;
            foreach (Item item in Inventory)
            {
                itemHealthBonus += item.BonusHealth + item.BonusArmor +(item.BonusMovement * MovementEffect);
            }
            return finalHealth += this.Damage + itemHealthBonus;
        }
    }
}
