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
   public  class TitleScreen : GameScreen
    {
        KeyboardState keyState;
        SpriteFont font;
        Texture2D womanHero;


        public override void LoadContent(ContentManager Content)
        {

            base.LoadContent(Content);
            if (font == null) font = Content.Load<SpriteFont>("Font1");
            if (womanHero == null) womanHero = Content.Load<Texture2D>("Sprites/womanH");
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Z)) ScreenManeger.Instance.AddScreen(new SplashScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "Choose Battle Heroes : Press \"Z\" main menue", new Vector2(100, 10), Color.Black);
            spriteBatch.Draw(womanHero, new Vector2(100, 30), Color.White);
        }
    }
}
