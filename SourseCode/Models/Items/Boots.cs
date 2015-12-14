using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourseCode.Models.Items
{
    public class Boots : Item
    {
        private const double DefautMovementBonus = 60;
        private const double DefautDamage = 0;      
        private const double DefautArmor = 0;
        private const double DefautHealth = 0;
        private const int DefautCritChannce = 0;

        public Boots() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
