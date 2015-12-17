namespace AlkonostXNAGame.AlkonostDataStructure.Interfaces
{
    public interface IItem
    {
        float BonusDamage { get; }
        float BonusArmor { get; }
        float BonusHealth { get; }
        float BonusMovement { get; }
        int BonusCritChance { get; }
    }
}