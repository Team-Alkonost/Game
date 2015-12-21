using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Flail : Item
    {
        private const int DefautMovementBonus = 0;
        private const int DefautDamage = 40;
        private const int DefautArmor = 0;
        private const int DefautHealth = 0;
        private const int DefautCritChannce = 0;

        public Flail() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
