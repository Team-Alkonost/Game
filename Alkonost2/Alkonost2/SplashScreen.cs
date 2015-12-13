
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
       Texture2D menueImage;
       public static Game1 game1 = new Game1();


       public override void LoadContent(ContentManager Content)
       {
           base.LoadContent(Content);
           if (menueImage == null) menueImage = Content.Load<Texture2D>("Sprites/MenueBackground");
       }

       public override void UnloadContent()
       {
           base.UnloadContent();
       }

       public override void Update(GameTime gameTime)
       {
           keyState = Keyboard.GetState();
           if (keyState.IsKeyDown(Keys.Enter))
               ScreenManeger.Instance.AddScreen(new TitleScreen());              

       }


       public override void Draw(SpriteBatch spriteBatch)
       {

           spriteBatch.Draw(menueImage, new Vector2(0, 0), Color.White);
         
       }
    }
}
