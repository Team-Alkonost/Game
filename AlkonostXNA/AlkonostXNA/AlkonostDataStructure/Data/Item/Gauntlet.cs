

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Gaunlet : Item
    {
        private const int DefautMovementBonus = 0;
        private const int DefautDamage = 0;
        private const int DefautArmor = 18;
        private const int DefautHealth = 50;
        private const int DefautCritChannce = 0;

        public Gaunlet() : base(DefautDamage, DefautArmor, DefautHealth, DefautMovementBonus, DefautCritChannce)
        {
        }
    }
}