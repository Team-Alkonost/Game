using AlkonostXNAGame.Config;
using AlkonostXNAGame.XNAData;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public partial class Player
    {
        public float velocity;
        public Texture2D texture;
        public Vector2 position;

        public void Initialize()
        {
            MovementSpeed = GameSettings.DefaultPlayerMovementSpeed;
            velocity = GameSettings.DefaultVelocity;
            position = GameSettings.StartingPlayerPosition;
        }

        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("Sprites/ship");
        }

        public void Update()
        {
            InputManager.Instance.ExecuteOnKeyPressed(GameSettings.UpKey, this.MoveUp);
            InputManager.Instance.ExecuteOnKeyPressed(GameSettings.DownKey, this.MoveDown);
            InputManager.Instance.ExecuteOnKeyPressed(GameSettings.LeftKey, this.MoveLeft);
            InputManager.Instance.ExecuteOnKeyPressed(GameSettings.RightKey, this.MoveRight);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        private void MoveUp()
        {
            if (this.position.Y - (MovementSpeed * velocity) >= 0)
            {
                this.position.Y -= MovementSpeed * velocity;
            }
        }

        private void MoveDown()
        {
            if (this.position.Y + (MovementSpeed * velocity) <= 645 - texture.Height)
            {
                this.position.Y += MovementSpeed * velocity;
            }
        }

        private void MoveRight()
        {
            if(this.position.X + (MovementSpeed * velocity) <= 700 - texture.Width)
            {
                this.position.X += MovementSpeed * velocity;
            }
        }

        private void MoveLeft()
        {
            if (this.position.X - (MovementSpeed * velocity) >= 0)
            {
                this.position.X -= MovementSpeed * velocity;
            }
        }
    }
}
