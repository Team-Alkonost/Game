namespace AlkonostXNAGame.AlkonostDataStructure.Interfaces
{
    public interface IItem
    {
        double BonusDamage { get; }
        double BonusArmor { get; }
        double BonusHealth { get; }
        double BonusMovement { get; }
        int BonusCritChance { get; }
    }
}