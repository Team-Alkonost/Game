

namespace SourseCode.Models.ModelsInterfases
{
    public interface IBonus
    {
        int BonusHealth { get; }
        int BonusArmor { get; }
        int BonusDamage { get; }
        int BonusMovement { get; }
    }
}
