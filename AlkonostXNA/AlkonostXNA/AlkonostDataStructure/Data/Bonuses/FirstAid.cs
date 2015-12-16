namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public class FirstAid : HelpPackage
    {
        private const int DefautHealthBonus = 100;
        private const int DefautArmorBonus = 0;
        private const int DefautDamageBonus = 0;
        private const int DefautMovementBonus = 0;

        public FirstAid() 
            : base (DefautHealthBonus, DefautArmorBonus, DefautDamageBonus, DefautMovementBonus)
        {

        }

    }
}
