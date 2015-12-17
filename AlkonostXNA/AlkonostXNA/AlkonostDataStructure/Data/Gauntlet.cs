

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Gaunlet : Item
    {
        private const float DefautMovementBonus = 0;
        private const float DefautDamage = 0;
        private const float DefautArmor = 18;
        private const float DefautHealth = 50;
        private const int DefautCritChannce = 0;

        public Gaunlet() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}