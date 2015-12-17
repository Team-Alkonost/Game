using System.Collections.Generic;
namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public partial class Player : Character
    {
        private const float DefaultHealthPoints = 100;
        private const float DefaultAttackPoints = 50;
        private const float DefaultArmorPoints = 10;
        private const float DefaultMovementSpeed = 100;
        private const float MovementEffect = 0.05f;        
        private HashSet<Item> inventory;

        public Player() 
            : base(DefaultHealthPoints, DefaultAttackPoints, DefaultArmorPoints, DefaultMovementSpeed)
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

        public override float Hit()
        {
            float damage =  this.CalculateAttackPoints();
            return damage;
        }

        protected override float CalculateAttackPoints()
        {
            float sumOfDamageOfItems = 0;
            float finalDamage = 0;
            foreach (Item item in Inventory)
            {               
                sumOfDamageOfItems += item.BonusDamage + (item.BonusMovement * MovementEffect);
            }

            finalDamage += this.AttackPoints + sumOfDamageOfItems;

            return finalDamage;            
        }

        public override float Defend()
        {
            float totalHealth = this.CalculateHealth();
            return totalHealth;
        }

        protected override float CalculateHealth()
        {
            float finalHealth = 0;
            float itemHealthBonus = 0;
            foreach (Item item in Inventory)
            {
                itemHealthBonus += item.BonusHealth + item.BonusArmor +(item.BonusMovement * MovementEffect);
            }

            return finalHealth += this.AttackPoints + itemHealthBonus;
        }
    }
}
