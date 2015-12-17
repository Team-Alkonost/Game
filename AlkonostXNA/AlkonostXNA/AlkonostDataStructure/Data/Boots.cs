using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Boots : Item
    {
        private const float DefautMovementBonus = 60;
        private const float DefautDamage = 0;      
        private const float DefautArmor = 0;
        private const float DefautHealth = 0;
        private const int DefautCritChannce = 0;

        public Boots() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
