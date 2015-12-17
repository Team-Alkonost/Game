using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Shield : Item
    {
        private const float DefautMovementBonus = 0;
        private const float DefautDamage = 0;
        private const float DefautArmor = 40;
        private const float DefautHealth = 50;
        private const int DefautCritChannce = 0;

        public Shield() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
