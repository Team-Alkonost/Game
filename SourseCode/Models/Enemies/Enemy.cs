
namespace SourseCode.Models.Enemies
{
    using System;
    using ModelsInterfases;

    public abstract class Enemy : Character, IEnemy, IAttackable
    {
        private IItem weapon;

        protected Enemy(double health, double damage, double armor, double movement, IItem weapon) 
            : base (health, damage, armor, movement)
        {
            this.         
        }

        public IItem Wеаpon
        {
            get
            {
                return this.weapon;
            }
            private set
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
            throw new NotImplementedException();
        }

        public override double Hit()
        {
            throw new NotImplementedException();
        }
    }
}
