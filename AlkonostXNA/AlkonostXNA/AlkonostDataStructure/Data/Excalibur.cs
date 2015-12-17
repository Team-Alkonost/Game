using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Excalibur : Item
    {
        private const float DefautMovementBonus = 0;
        private const float DefautDamage = 20;
        private const float DefautArmor = 0;
        private const float DefautHealth = 0;
        private const int DefautCritChannce = 1;

        public Excalibur() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
