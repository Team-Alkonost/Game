using AlkonostXNAGame.AlkonostDataStructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourseCode.Models.Enemies
{
    public class Knight : Enemy
    {
        private const double DefautHealth = 20;
        private const double DefautDamage = 10;
        private const double DefautArmor = 12;
        private const double DefautMovement = 15;

        public Knight() : base (DefautHealth, DefautDamage, DefautArmor, DefautMovement)
        {
            this.Wеаpon = new Excalibur();
        }
    }
}
