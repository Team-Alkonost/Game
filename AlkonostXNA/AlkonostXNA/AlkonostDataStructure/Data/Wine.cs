namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class Wine : HelpPackage
    {
        private const int DefautHealthBonus = 0;
        private const int DefautArmorBonus = 0;
        private const int DefautDamageBonus = 0;
        private const int DefautMovementBonus = 90;

        public Wine()
            : base(DefautHealthBonus, DefautArmorBonus, DefautDamageBonus, DefautMovementBonus)
        {

        }
    }
}