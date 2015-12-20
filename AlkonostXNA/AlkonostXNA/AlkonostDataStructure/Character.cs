using System;
using AlkonostXNAGame.AlkonostDataStructure.Interfaces;

namespace AlkonostXNAGame.AlkonostDataStructure
{
    public abstract class Character : ICharacter, IAttackable
    {
        private float armorPoints;
        private float attackPoints;
        private float healthPoints;
        private float movementSpeed;
            
        protected Character(float healthPoints, float attackPoints, float armorPoints, float movementSpeed)
        {
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.ArmorPoints = armorPoints;
            this.MovementSpeed = movementSpeed;
        }           

        public float ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("ArmorPoints cannot be negative");
                }
                this.armorPoints = value;
            }            
        }

        public float AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("AttackPoints cannot be negative");
                }
                this.attackPoints = value;
            }
        }

        public float HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("HealthPoints cannot be negative");
                }
                this.healthPoints = value;
            }
        }

        public float MovementSpeed
        {
            get
            {
                return this.movementSpeed;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("MovementSpeed cannot be negative");
                }
                this.movementSpeed = value;
            }
        }


        public abstract float Hit();

        public abstract float Defend();

        protected abstract float CalculateHealth();

        protected abstract float CalculateAttackPoints();
    }
}
