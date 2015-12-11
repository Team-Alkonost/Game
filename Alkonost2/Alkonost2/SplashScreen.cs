
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
   public class SplashScreen : GameScreen
    {
       KeyboardState keyState;
       SpriteFont font;

       public override void LoadContent(ContentManager Content)
       {
           base.LoadContent(Content);
           if (font == null) font = Content.Load<SpriteFont>("Font1");
       }

       public override void UnloadContent()
       {
           base.UnloadContent();
       }

       public override void Update(GameTime gameTime)
       {
           keyState = Keyboard.GetState();
           if (keyState.IsKeyDown(Keys.Z)) 
               ScreenManeger.Instance.AddScreen(new TitleScreen());
       }

       public override void Draw(SpriteBatch spriteBatch)
       {
          
           spriteBatch.DrawString(font, "SplashScreen", new Vector2(100, 100), Color.Black);
         
       }
    }
}
