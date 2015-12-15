namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class WhetStone : HelpPackage
    {
        private const int DefautHealthBonus = 0;
        private const int DefautArmorBonus = 0;
        private const int DefautDamageBonus = 30;
        private const int DefautMovementBonus = 0;

        public WhetStone() 
            : base (DefautHealthBonus, DefautArmorBonus, DefautDamageBonus, DefautMovementBonus)
        {

        }
    }
}