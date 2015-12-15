
using System.Collections.Generic;

namespace SourseCode.Models
{
    public class Player : Character
    {
        private const double DefautHealth = 100;
        private const double DefautDamage = 50;
        private const double DefautArmor = 10;
        private const double DefautMovement = 100;
        private const double MovementEfect = 0.05;        
        private HashSet<Item> inventory;

        public Player(double healt, double damage, double armor, double movement) 
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
        private double CalculateAttackPoints()
        {
            double sumOfDamageOfItems = 0;
            double finalDamage = 0;
            foreach (Item item in Inventory)
            {               
                sumOfDamageOfItems += item.BonusDamage + (item.BonusMovement * MovementEfect);
            }
            finalDamage += this.Damage + sumOfDamageOfItems;

            return finalDamage;            
        }

        public override double Defend()
        {
            double totalHealth = this.CalculateHealth();
            return totalHealth;
        }

        public double CalculateHealth()
        {
            double finalHealth = 0;
            double itemHealthBonus = 0;
            foreach (Item item in Inventory)
            {
                itemHealthBonus += item.BonusHealth + item.BonusArmor +(item.BonusMovement * MovementEfect);
            }
            return finalHealth += this.Damage + itemHealthBonus;
        }
    }
}
