using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alkonost2.Models
{
    public class Gaunlet : Item
    {
        private const double DefautMovementBonus = 0;
        private const double DefautDamage = 0;
        private const double DefautArmor = 18;
        private const double DefautHealth = 50;
        private const int DefautCritChannce = 0;

        public Gaunlet() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
