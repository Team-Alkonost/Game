using AlkonostXNAGame.Config;
using AlkonostXNAGame.XNAData;
using AlkonostXNAGame.XNAData.CharacterAnimation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public partial class Player
    {
        public float velocity;
        public Texture2D playerTexture;
        public Vector2 position;
        public Vector2 origin;
        public Rectangle sourceRect;
        

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Vector2 Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public Texture2D PlayerTexture
        {
            get { return playerTexture; }
            set { playerTexture = value; }
        }

        public Rectangle SourceRect
        {
            get { return sourceRect; }
            set { sourceRect = value; }
        }

        public void Initialize()
        {
            MovementSpeed = GameSettings.DefaultPlayerMovementSpeed;
            velocity = GameSettings.DefaultVelocity;
            position = GameSettings.StartingPlayerPosition;
        }

        public void LoadContent(ContentManager content)
        {
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
            spriteBatch.Draw(playerTexture, position, Color.White);
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
            if (this.position.Y + (MovementSpeed * velocity) <= 645 - playerTexture.Height)
            {
                this.position.Y += MovementSpeed * velocity;
            }
        }

        private void MoveRight()
        {
            if(this.position.X + (MovementSpeed * velocity) <= 700 - playerTexture.Width)
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
