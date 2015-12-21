namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class ArmorUpgrade : HelpPackage
    {
        private const int DefautHealthBonus = 0;
        private const int DefautArmorBonus = 15;
        private const int DefautDamageBonus = 0;
        private const int DefautMovementBonus = 0;

        public ArmorUpgrade()
            : base(DefautHealthBonus, DefautArmorBonus, DefautDamageBonus, DefautMovementBonus)
        {

        }
    }
}