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
        private const int DefautHealth = 20;
        private const int DefautDamage = 10;
        private const int DefautArmor = 12;
        private const int DefautMovement = 15;

        public Knight() : base (DefautHealth, DefautDamage, DefautArmor, DefautMovement)
        {
            this.Wеаpon = new Excalibur();
        }
    }
}
