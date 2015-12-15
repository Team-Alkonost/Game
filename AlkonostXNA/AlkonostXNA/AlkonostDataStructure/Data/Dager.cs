using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Dager : Item
    {
        private const double DefautMovementBonus = 0;
        private const double DefautDamage = 10;
        private const double DefautArmor = 0;
        private const double DefautHealth = 0;
        private const int DefautCritChannce = 2;

        public Dager() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
