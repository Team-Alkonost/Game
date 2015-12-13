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
    using GameGraphic;

    

    class ScreenMap:GameScreen
    {
        KeyboardState keyState;
        public Texture2D texture;
        public Vector2  position ;
        public int speed;
        Map map;
        
        public ScreenMap()
        {
            texture = null;
            position = new Vector2(300, 300);
            map = new Map();
            speed = 10;
        }

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            texture = Content.Load<Texture2D>("Sprites/ship");
            Tiles.Content = Content; //map class
            map.Generate(new int[,]{
                {1,1,1,1,1,1,1,1,1,1,1,1},
                {1,2,2,2,2,2,2,2,2,1,1,1},
                {1,2,2,2,2,2,2,2,2,1,1,1},
                {1,2,2,2,2,2,2,2,2,1,1,1},
                {1,2,2,2,2,2,2,2,2,1,1,1},
                {1,2,2,2,2,2,2,2,2,1,1,1},
                {1,2,2,2,2,2,2,2,2,1,1,1},
                {1,2,2,2,2,2,2,2,2,1,1,1},
                {1,2,2,2,2,2,2,2,2,1,1,1},
                {1,1,1,1,1,1,1,1,1,1,1,1},
            }, 64);  //map class
            
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
           
            if (keyState.IsKeyDown(Keys.Up)) position.Y = position.Y - speed;
            if (keyState.IsKeyDown(Keys.Left)) position.X = position.X - speed;
            if (keyState.IsKeyDown(Keys.Down)) position.Y = position.Y + speed;
            if (keyState.IsKeyDown(Keys.Right)) position.X = position.X + speed;
            if (position.X <= 0) position.X = 0;
            if (position.X >= 645 - texture.Width) position.X = 645 - texture.Width;
            if (position.Y <= 0) position.Y = 0;
            if (position.Y >= 645 - texture.Height) position.Y = 645 - texture.Height;
            //exit from this window
            if (keyState.IsKeyDown(Keys.Z)) ScreenManeger.Instance.AddScreen(new SplashScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch);
            spriteBatch.Draw(texture, position, Color.White);
         
        }
    }
}
