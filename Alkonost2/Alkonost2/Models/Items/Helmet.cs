using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alkonost2.Models.Items
{
    public class Helmet : Item
    {
        private const double DefautMovementBonus = 0;
        private const double DefautDamage = 0;
        private const double DefautArmor = 35;
        private const double DefautHealth = 15;
        private const int DefautCritChannce = 0;

        public Helmet() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
