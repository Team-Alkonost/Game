using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourseCode.Models.Items
{
    public class Sheald : Item
    {
        private const double DefautMovementBonus = 0;
        private const double DefautDamage = 0;
        private const double DefautArmor = 40;
        private const double DefautHealth = 50;
        private const int DefautCritChannce = 0;

        public Sheald() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
