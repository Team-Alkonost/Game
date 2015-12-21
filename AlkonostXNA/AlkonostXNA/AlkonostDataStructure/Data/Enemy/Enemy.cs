
namespace SourseCode.Models.Enemies
{
    using AlkonostXNAGame.AlkonostDataStructure;
    using AlkonostXNAGame.AlkonostDataStructure.Interfaces;
    using System;

    public abstract class Enemy : Character, IEnemy, IAttackable
    {
        private IItem weapon;
        private const int MovementEffect = 7;

        protected Enemy(int health, int damage, int armor, int movement) 
            : base (health, damage, armor, movement)
        {
            this.Wеаpon = weapon; 
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

        public override int Defend()
        {
            int totalHealth = this.CalculateHealth();
            return totalHealth;
        }

        public override int Hit()
        {
            int totalDamage = this.CalculateAttackPoints();
            return totalDamage;
        }

        protected override int CalculateAttackPoints()
        {
            int finalDamage = this.AttackPoints + this.Wеаpon.BonusDamage + (weapon.BonusMovement + MovementEffect);
            return finalDamage;
        }

        protected override int CalculateHealth()
        {
            int finalHealth = this.HealthPoints + this.Wеаpon.BonusHealth + (weapon.BonusMovement + MovementEffect);
            return finalHealth;
        }
    }
}
