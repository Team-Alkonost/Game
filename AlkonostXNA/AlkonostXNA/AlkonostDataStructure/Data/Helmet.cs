using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Helmet : Item
    {
        private const float DefautMovementBonus = 0;
        private const float DefautDamage = 0;
        private const float DefautArmor = 35;
        private const float DefautHealth = 15;
        private const int DefautCritChannce = 0;

        public Helmet() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
