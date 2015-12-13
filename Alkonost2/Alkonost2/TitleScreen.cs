using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Alkonost2
{
    public class TitleScreen : GameScreen
    {
        protected KeyboardState keyState;
        protected SpriteFont font;
        protected SpriteFont font2;
        protected Texture2D womanHero;
        protected Texture2D knights;

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            if (font == null) font = Content.Load<SpriteFont>("Font1");
            if (font2 == null) font2 = Content.Load<SpriteFont>("Font2");
            if (womanHero == null) womanHero = Content.Load<Texture2D>("Sprites/womanH");//knights
            if (knights == null) knights = Content.Load<Texture2D>("Sprites/knights");
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Z))
            {
                ScreenManeger.Instance.AddScreen(new SplashScreen());
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "Choose Battle Heroes : Press \"Z\" back to main menu", new Vector2(100, 10), Color.Black);
            spriteBatch.Draw(womanHero, new Vector2(100, 30), Color.White);
            spriteBatch.DrawString(font, "Life : 100 ", new Vector2(300, 100), Color.Blue);
            spriteBatch.DrawString(font, "Damage : 50 ", new Vector2(300, 140), Color.Blue);
            spriteBatch.DrawString(font, "Armor : 10 ", new Vector2(300, 180), Color.Blue);
            spriteBatch.DrawString(font, "Mouvement : 100 ", new Vector2(300, 220), Color.Blue);
            spriteBatch.Draw(knights, new Vector2(80, 330), Color.White);
            spriteBatch.DrawString(font, "Life : 100 ", new Vector2(300, 380), Color.Red);
            spriteBatch.DrawString(font, "Damage : 70 ", new Vector2(300, 420), Color.Red);
            spriteBatch.DrawString(font, "Armor : 15 ", new Vector2(300, 460), Color.Red);
            spriteBatch.DrawString(font, "Mouvement : 80 ", new Vector2(300, 500), Color.Red);
        }
    }
}