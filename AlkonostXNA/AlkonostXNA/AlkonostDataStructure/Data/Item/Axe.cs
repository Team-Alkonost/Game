﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Axe : Item
    {
        private const int DefautMovementBonus = 0;
        private const int DefautDamage = 0;
        private const int DefautArmor = 30;
        private const int DefautHealth = 0;
        private const int DefautCritChannce = 1;

        public Axe() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}
