using System;
using AlkonostXNAGame.AlkonostDataStructure.Exceptions;
using AlkonostXNAGame.AlkonostDataStructure.Interfaces;

namespace AlkonostXNAGame.AlkonostDataStructure
{
    using XNAData;
    public abstract class Character : ICharacter, IAttackable
    {
        private float armorPoints;
        private float attackPoints;
        private int healthPoints;
        private float movementSpeed;
            
        protected Character(int healthPoints, float attackPoints, float armorPoints, float movementSpeed)
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
                    throw new AlkonostException("Armor point must be a positive integer number.");
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
                    throw new AlkonostException("Attack points must be a positive integer number.");
                }
                this.attackPoints = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            protected set
            {
                if (value <= 0)
                {
                    ScreenManager.Instance.AddScreen(new GameoverScreen());     
                   
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


        public abstract int Hit();

        public abstract float Defend();

        protected abstract int CalculateHealth();

        protected abstract float CalculateAttackPoints();
    }
}
