using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Helmet : Item
    {
        private const int DefautMovementBonus = 0;
        private const int DefautDamage = 0;
        private const int DefautArmor = 35;
        private const int DefautHealth = 15;
        private const int DefautCritChannce = 0;

        public Helmet() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
