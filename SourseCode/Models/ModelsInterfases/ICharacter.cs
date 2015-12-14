

using Microsoft.Xna.Framework.Graphics;

namespace SourseCode.Models.ModelsInterfases
{
    public  interface ICharacter
    {
        double Health { get; }
        double Damage { get; }
        double Armor { get; }
        double Movement { get; }
        Texture2D Image { get; }
    }
}
