using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using AlkonostXNAGame.AlkonostDataStructure.Data;

namespace AlkonostXNAGame.XNAData
{
    using GameGraphic;
    using CharacterAnimation;
    using AlkonostDataStructure;
    

    class ScreenMap:GameScreen
    {
        KeyboardState keyState;
       // public Texture2D texture;
        public Vector2  position ;
        public int speed;
        Map map;
       Player player;
       // Player player1;
       Texture2D Gameinfo;

        SpriteFont font;
        string Colision="";
        string case1 = "";
        int enemyHeroes = 0;
        int playerlife = 100;
        //World map
        int[,] matrix1 = new int[,]{
                {4,1,1,1,1,1,1,1,1,1,1,1,4,1,1,1,1,1,1,1,1,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,1,1,5,7,1,1,2,2,2,2,2,2,1},
                {1,2,2,2,2,2,2,2,2,4,1,6,2,1,1,2,2,2,2,2,2,1},
                {1,5,5,5,5,5,5,5,5,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,6,6,6,6,6,6,6,6,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,5,5,5,5,5,5,5,5,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,6,6,6,6,6,6,6,6,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,4,7,1,1,5,1,1,1,1,4,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,6,1,1,1,1,4,1,1,1,2,2,2,2,2,2,1},
                {4,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,2,2,2,1,1,4,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {4,1,2,2,2,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {1,1,2,2,2,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,1},
                {4,1,5,1,1,1,1,5,1,1,1,1,1,1,4,5,5,5,5,5,5,1},
                {4,4,6,2,1,1,1,6,2,1,1,1,1,1,4,6,6,6,6,6,6,1},
                {7,1,1,1,1,1,1,1,1,7,1,1,1,1,1,1,1,1,1,1,1,1},
            };

        public ScreenMap()
        {
         
           // position = new Vector2(300, 300);
            map = new Map();
            player = new Player();
          //  player1 = new Player();
            
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
            if (Gameinfo == null) Gameinfo = Content.Load<Texture2D>("Sprites/List");//knights
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
            if (player.position.X >= 695 ) player.position.X = 695;
            if (player.position.Y <= 0) player.position.Y = 0;
            if (player.position.Y >= 675 ) player.position.Y = 675;
            //exit from this window
          //  if (keyState.IsKeyDown(Keys.Z)) ScreenManeger.Instance.AddScreen(new SplashScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch);
            
            player.Draw(spriteBatch);
            int pointX = (int)player.position.X / 32;
            string gX = pointX.ToString();
            int pointY = (int)player.position.Y / 32;
            string gY = pointY.ToString();
           //--Load from file
               if (matrix1[pointY, pointX] == 4)  //4=enemy
                {                
                    matrix1[pointY, pointX] = 1;    //update matrix  
                    case1 = "Enemy is ded";
                    Colision = "      " + player.Hit().ToString();
                    playerlife=player.Hit();                
                    enemyHeroes++;
                   this.map.Generate(matrix1, 32);  //reload matrixx          
                }
               if (matrix1[pointY, pointX] == 7)  // 4= open case
               {
                   matrix1[pointY, pointX] = 1;    //update matrix                 
                   case1 = "You find Life";                   
                   player.AddHealth(15); playerlife += 15;
                   Colision = "      " + playerlife.ToString(); 
                   this.map.Generate(matrix1, 32);  //reload matrixx              
               }
            //--Load from file
               if (playerlife <= 0)  { case1 = "Game over !";   }
            //Draw 
            spriteBatch.Draw(Gameinfo, new Vector2(705, 00), Color.White); //Picture List.png
            spriteBatch.DrawString(font, "1", new Vector2(790, 27), Color.Blue); // Level
            spriteBatch.DrawString(font, " " + enemyHeroes.ToString(), new Vector2(840, 93), Color.Blue); //Enemy Kiled
            spriteBatch.DrawString(font, Colision, new Vector2(780, 150), Color.Blue);   //Player life
            spriteBatch.DrawString(font, "70", new Vector2(810, 193), Color.Blue);   //damage
            spriteBatch.DrawString(font, "15", new Vector2(810, 237), Color.Blue);   //Armor
            spriteBatch.DrawString(font, "80", new Vector2(840, 270), Color.Blue); //mouvement
            if (case1 != "") spriteBatch.DrawString(font, case1, new Vector2(800, 305), Color.Blue);  //Game info 
            
             
        }

     
    }
}


