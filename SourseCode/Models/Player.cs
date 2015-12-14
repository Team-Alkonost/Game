using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alkonost2.Models.ModelsInterfases;
using Microsoft.Xna.Framework.Graphics;

namespace SourseCode.Models
{
    public class Player : Character
    {
        private const double DefautHealth = 100;
        private const double DefautDamage = 50;
        private const double DefautArmor = 10;
        private const double DefautMovement = 100;
        private const double MovementEfect = 0.05;        
        private readonly List<Item> inventory;

        public Player(double healt, double damage, double armor, double movement, Texture2D image) 
            : base(DefautHealth, DefautDamage, DefautArmor, DefautMovement, image)
        {
            this.inventory = new List<Item>();
            this.CritChance = 3;
        }

        public IEnumerable<Item> Inventory
        {
            get
            {
                return this.inventory;
            }
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

        public double Defend()
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
