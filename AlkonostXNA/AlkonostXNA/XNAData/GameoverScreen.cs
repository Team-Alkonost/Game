using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AlkonostXNAGame.XNAData
{
    class GameoverScreen : GameScreen
    {
        KeyboardState keyState; 
        SpriteFont font;
        SpriteFont font1;


        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            if (font1 == null) font1 = Content.Load<SpriteFont>("Sprites/Font3");
            if (font == null) font = Content.Load<SpriteFont>("Font1");
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Z)) ScreenManager.Instance.AddScreen(new SplashScreen());
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "Choose Battle Heroes : Press \"Z\"  back  to main menu", new Vector2(100, 10), Color.Black);
            spriteBatch.DrawString(font1, "Game over !", new Vector2(350, 300), Color.Red);
        }

    }
}
