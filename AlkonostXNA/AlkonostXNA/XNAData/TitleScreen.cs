﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AlkonostXNAGame.XNAData
{
    public class TitleScreen : GameScreen
    {
        KeyboardState keyState;
        SpriteFont font;
        SpriteFont font2;
        Texture2D womanHero;
        Texture2D knights;

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
            if (keyState.IsKeyDown(Keys.Z)) ScreenManager.Instance.AddScreen(new SplashScreen());
            if (keyState.IsKeyDown(Keys.M)) ScreenManager.Instance.AddScreen(new ScreenMap());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "Choose Battle Heroes : Press \"Z\"  back  to main menu Press\"M\" go to the Map", new Vector2(100, 10), Color.Black);
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
