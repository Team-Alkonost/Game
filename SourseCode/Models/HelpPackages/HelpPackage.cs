

namespace SourseCode.Models.HelpPackeges
{
    using System;
    using ModelsInterfases;
    public abstract class HelpPackage : IBonus
    {
        private int bonusArmor;
        private int bonusDamage;
        private int bonusHealth;
        private int bonusMovement;

        protected HelpPackage(int bonusHealth, int bonusArmor, int bonusDamage, int bonusMovement)
        {
            this.BonusHealth = bonusHealth;
            this.BonusArmor = bonusArmor;
            this.BonusDamage = bonusDamage;
            this.BonusMovement = bonusMovement;
        } 

        public int BonusArmor
        {
            get
            {
                return this.bonusArmor;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Bonus armor cannot be negative");
                }
                this.bonusArmor = value;
            }
        }

        public int BonusDamage
        {
            get
            {
                return this.bonusDamage;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Bonus damage cannot be negative");
                }
                this.bonusDamage = value;
            }
        }

        public int BonusHealth
        {
            get
            {
                return this.bonusHealth;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Bonus health cannot be negative");
                }
                this.bonusHealth = value;
            }
        }

        public int BonusMovement
        {
            get
            {
                return this.bonusMovement;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Bonus movement cannot be negative");
                }
                this.bonusMovement = value;
            }
        }
    }
}
