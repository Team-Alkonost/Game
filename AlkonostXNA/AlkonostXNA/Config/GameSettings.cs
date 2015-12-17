using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace AlkonostXNAGame.Config
{
    public static class GameSettings
    {
        // Player input settings.
        public const Keys UpKey = Keys.W;
        public const Keys DownKey = Keys.S;
        public const Keys LeftKey = Keys.A;
        public const Keys RightKey = Keys.D;

        public const float DefaultVelocity = 1f;
        public const float DefaultPlayerMovementSpeed = 2f;
        public readonly static Vector2 StartingPlayerPosition = new Vector2(300, 300);
    }
}
