using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Flail : Item
    {
        private const float DefautMovementBonus = 0;
        private const float DefautDamage = 40;
        private const float DefautArmor = 0;
        private const float DefautHealth = 0;
        private const int DefautCritChannce = 0;

        public Flail() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
