
namespace Alkonost2.Models.ModelsInterfases
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
