﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Shield : Item
    {
        private const int DefautMovementBonus = 0;
        private const int DefautDamage = 0;
        private const int DefautArmor = 40;
        private const int DefautHealth = 50;
        private const int DefautCritChannce = 0;

        public Shield() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
