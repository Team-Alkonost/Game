using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Axe : Item
    {
        private const float DefautMovementBonus = 0;
        private const float DefautDamage = 0;
        private const float DefautArmor = 30;
        private const float DefautHealth = 0;
        private const int DefautCritChannce = 1;

        public Axe() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
