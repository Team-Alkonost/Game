
namespace SourseCode.Models.Enemies
{
    using AlkonostXNAGame.AlkonostDataStructure;
    using AlkonostXNAGame.AlkonostDataStructure.Interfaces;
    using System;

    public abstract class Enemy : Character, IEnemy, IAttackable
    {
        private IItem weapon;
        private const double MovementEffect = 0.07;

        protected Enemy(double health, double damage, double armor, double movement) 
            : base (health, damage, armor, movement)
        {     
        }

        public IItem Wеаpon
        {
            get
            {
                return this.weapon;
            }
            protected set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Weapon must be valid");
                }
                this.weapon = value;
            }
        }

        public override double Defend()
        {
            double totalHealth = this.CalculateHealth();
            return totalHealth;
        }

        public override double Hit()
        {
            double totalDamage = this.CalculateAttackPoints();
            return totalDamage;
        }

        protected override double CalculateAttackPoints()
        {
            double finalDamage = this.Damage + this.Wеаpon.BonusDamage + (weapon.BonusMovement + MovementEffect);
            return finalDamage;
        }

        protected override double CalculateHealth()
        {
            double finalHealth = this.Health + this.Wеаpon.BonusHealth + (weapon.BonusMovement + MovementEffect);
            return finalHealth;
        }
    }
}
