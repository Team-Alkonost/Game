using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace AlkonostXNAGame.XNAData
{
    using GameGraphic;

    

    class ScreenMap:GameScreen
    {
        KeyboardState keyState;
        public Texture2D texture;
        public Vector2  position ;
        public int speed;
        Map map;
        SpriteFont font;

        public ScreenMap()
        {
            texture = null;
            position = new Vector2(300, 300);
            map = new Map();
            speed = 3;
            
        }

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            texture = Content.Load<Texture2D>("Sprites/ship");
            Tiles.Content = Content; //map class
            if (font == null) font = Content.Load<SpriteFont>("Font1");
            map.Generate(new int[,]{
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,3,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,2,2,2,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,2,2,2,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,2,2,2,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            }, 32);  //map class

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
            if (position.X >= 700 - texture.Width) position.X = 700 - texture.Width;
            if (position.Y <= 0) position.Y = 0;
            if (position.Y >= 645 - texture.Height) position.Y = 645 - texture.Height;
            //exit from this window
            if (keyState.IsKeyDown(Keys.Z)) ScreenManeger.Instance.AddScreen(new SplashScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch);
            spriteBatch.Draw(texture, position, Color.White);
            float g = position.X;
            string h = g.ToString();
            float g2 = position.Y;
            string h2 = g2.ToString();

            if (position.X == 354)
                if (position.Y == 354) { spriteBatch.DrawString(font, "Colision", new Vector2(750, 150), Color.Blue); }
            spriteBatch.DrawString(font, h, new Vector2(750, 50), Color.Blue);
            spriteBatch.DrawString(font, h2, new Vector2(750, 100), Color.Blue);
        }
    }
}
