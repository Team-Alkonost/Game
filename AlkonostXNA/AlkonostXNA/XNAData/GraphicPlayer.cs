using AlkonostXNAGame.Config;
using AlkonostXNAGame.XNAData;
using AlkonostXNAGame.XNAData.CharacterAnimation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace AlkonostXNAGame.AlkonostDataStructure.Data
{
    public partial class Player
    {
        public float velocity;
        public Vector2 position;
        public KnightAnimation animation;

        public void Initialize()
        {
            animation = new KnightAnimation();
            animation.Initialize();
            MovementSpeed = GameSettings.DefaultPlayerMovementSpeed;
            velocity = GameSettings.DefaultVelocity;
            position = GameSettings.StartingPlayerPosition;
        }

        public void LoadContent(ContentManager content)
        {
            animation.LoadContent(content);
        }

        public void Update(GameTime gameTime)
        {
            animation.Update();
            if (InputManager.Instance.IsKeyPressed(GameSettings.UpKey))
            {
                this.animation.AnimateUp(gameTime);
                this.MoveUp();
            }
            if (InputManager.Instance.IsKeyPressed(GameSettings.DownKey))
            {
                this.animation.AnimateDown(gameTime);
                this.MoveDown();
            }
            if (InputManager.Instance.IsKeyPressed(GameSettings.LeftKey))
            {
                this.animation.AnimateLeft(gameTime);
                this.MoveLeft();
            }
            if (InputManager.Instance.IsKeyPressed(GameSettings.RightKey))
            {
                this.animation.AnimateRight(gameTime);
                this.MoveRight();
            }
            if (InputManager.Instance.IsKeyPressed(GameSettings.RunKey))
            {
                velocity = 3;
            }
            else
            {
                velocity = GameSettings.DefaultVelocity;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.animation.texture, this.position, this.animation.sourceRect, Color.White, 0f, this.animation.origin, 1.0f, SpriteEffects.None, 0);
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
            if (this.position.Y + (MovementSpeed * velocity) <= 665 - this.animation.texture.Height)
            {
                this.position.Y += MovementSpeed * velocity;
            }
        }

        private void MoveRight()
        {
            if(this.position.X + (MovementSpeed * velocity) <= 2100 - this.animation.texture.Width)
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

        private void ChooseAnimation()
        {
            
        }
    }
}
