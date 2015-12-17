using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using AlkonostXNAGame.AlkonostDataStructure.Data;

namespace AlkonostXNAGame.XNAData
{
    using GameGraphic;
    using CharacterAnimation;
    
    

    class ScreenMap:GameScreen
    {
        KeyboardState keyState;
       // public Texture2D texture;
        public Vector2  position ;
        public int speed;
        Map map;
        Player player;
        SpriteFont font;
        string Colision="";
        int[,] matrix1 = new int[,]{
                {4,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
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
                {1,1,1,1,1,1,1,1,1,1,1,4,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,2,2,2,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,2,2,2,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,2,2,2,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {4,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            };

        public ScreenMap()
        {
         
           // position = new Vector2(300, 300);
            map = new Map();
            player = new Player();
            speed = 3;
            player.Initialize();
           
            
        }

        public override void Initialize()
        {
            player.Initialize();
            base.Initialize();
        }

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            
            Tiles.Content = Content; //map class
            if (font == null) font = Content.Load<SpriteFont>("Font1");
            map.Generate(matrix1, 32);  //map class
            player.LoadContent(content);
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
            player.Update(gameTime);

            if (player.position.X <= 0) player.position.X = 0;
            if (player.position.X >= 700-20 ) player.position.X = 700 - 20;
            if (player.position.Y <= 0) player.position.Y = 0;
            if (player.position.Y >= 645 - 20) player.position.Y = 645 - 20;
            //exit from this window
          //  if (keyState.IsKeyDown(Keys.Z)) ScreenManeger.Instance.AddScreen(new SplashScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch);
           // spriteBatch.Draw(texture, position, Color.White);
            player.Draw(spriteBatch);
            int g = (int)player.position.X / 32;
            string gX = g.ToString();
            int g2 = (int)player.position.Y / 32;
            string gY = g2.ToString();
           //--Load from file
            if (g == 11)
                if (g2 == 10)
                {
                  matrix1[11, 11] = 1;  //update matrix
                  this.map.Generate(matrix1, 32);  //reload matrixx
                  Colision= "Enemy ded ";   }
            if (g == 0)
                if (g2 == 0)
                {
                    matrix1[0, 0] = 1;  //update matrix
                    this.map.Generate(matrix1, 32);  //reload matrixx
                    Colision = "Enemy ded ";
                }
            if (g == 0)
                if (g2 == 21)
                {
                    matrix1[0, 21] = 1;  //update matrix
                    this.map.Generate(matrix1, 32);  //reload matrixx
                    Colision = "Enemy ded ";
                }
            //--Load from file
            spriteBatch.DrawString(font, gX, new Vector2(750, 50), Color.Blue);
            spriteBatch.DrawString(font, gY, new Vector2(750, 100), Color.Blue);
            spriteBatch.DrawString(font, Colision, new Vector2(750, 150), Color.Blue); 
        }

     
    }
}
