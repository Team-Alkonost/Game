using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourseCode.Models.Items
{
    public class Excalibur : Item
    {
        private const double DefautMovementBonus = 0;
        private const double DefautDamage = 20;
        private const double DefautArmor = 0;
        private const double DefautHealth = 0;
        private const int DefautCritChannce = 1;

        public Excalibur() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
