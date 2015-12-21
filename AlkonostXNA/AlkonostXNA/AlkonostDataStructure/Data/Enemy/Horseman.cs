using AlkonostXNAGame.AlkonostDataStructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourseCode.Models.Enemies
{
    public class Horseman : Enemy
    {
        private const int DefautHealth = 12;
        private const int DefautDamage = 15;
        private const int DefautArmor = 10;
        private const int DefautMovement = 30;

        public Horseman() : base (DefautHealth, DefautDamage, DefautArmor, DefautMovement)
        {
            this.Wеаpon = new Helmet();
        }
    }
}
