using System;


namespace SourseCode.Models
{
    using ModelsInterfases;

    public abstract class Character : ICharacter, IAttackable
    {
        private double armor;
        private double damage;
        private double health;
        private double movement;
            
        protected Character(double health, double damage, double armor, double movement)
        {
            this.Health = health;
            this.Damage = damage;
            this.Armor = armor;
            this.Movement = movement;
        }           

        public double Armor
        {
            get
            {
                return this.armor;
            }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Armor cannot be negative");
                }
                this.armor = value;
            }            
        }

        public double Damage
        {
            get
            {
                return this.damage;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Damage cannot be negative");
                }
                this.damage = value;
            }
        }

        public double Health
        {
            get
            {
                return this.health;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health cannot be negative");
                }
                this.health = value;
            }
        }

        public double Movement
        {
            get
            {
                return this.movement;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Movement cannot be negative");
                }
                this.movement = value;
            }
        }


        public abstract double Hit();

        public abstract double Defend();
    }
}
