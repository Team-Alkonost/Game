using System;
using AlkonostXNAGame.AlkonostDataStructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SourseCode.Models.Enemies
{
    public class Spearman : Enemy
    {
        private const double DefautHealth = 14;
        private const double DefautDamage = 16;
        private const double DefautArmor = 8;
        private const double DefautMovement = 20;

        public Spearman() : base (DefautHealth, DefautDamage, DefautArmor, DefautMovement)
        {
            this.Wеаpon = new Shield();
        }
    }
}
