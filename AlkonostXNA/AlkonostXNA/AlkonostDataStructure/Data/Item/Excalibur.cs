using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Excalibur : Item
    {
        private const int DefautMovementBonus = 0;
        private const int DefautDamage = 20;
        private const int DefautArmor = 0;
        private const int DefautHealth = 0;
        private const int DefautCritChannce = 1;

        public Excalibur() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
