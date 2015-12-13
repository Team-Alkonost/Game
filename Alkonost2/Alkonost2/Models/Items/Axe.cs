using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alkonost2.Models.Items
{
    public class Axe : Item
    {
        private const double DefautMovementBonus = 0;
        private const double DefautDamage = 0;
        private const double DefautArmor = 30;
        private const double DefautHealth = 0;
        private const int DefautCritChannce = 1;

        public Axe() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
