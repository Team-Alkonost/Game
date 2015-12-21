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
        private const int DefautHealth = 14;
        private const int DefautDamage = 16;
        private const int DefautArmor = 8;
        private const int DefautMovement = 20;

        public Spearman() : base (DefautHealth, DefautDamage, DefautArmor, DefautMovement)
        {
            this.Wеаpon = new Shield();
        }
    }
}
