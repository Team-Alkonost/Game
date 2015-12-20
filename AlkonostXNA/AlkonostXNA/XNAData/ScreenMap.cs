﻿using Microsoft.Xna.Framework;
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
                    case1 = "Enamy is ded";
                    Colision = "Life: " + player.Hit().ToString();
                    playerlife=player.Hit();                
                    enemyHeroes++;
                   this.map.Generate(matrix1, 32);  //reload matrixx          
                }
               if (matrix1[pointY, pointX] == 7)  // 4= open case
               {
                   matrix1[pointY, pointX] = 1;    //update matrix                 
                   case1 = "You find Life";                   
                   player.AddHealth(15); playerlife += 15;
                   Colision = "Life: " + playerlife.ToString(); 
                   this.map.Generate(matrix1, 32);  //reload matrixx              
               }
            //--Load from file
            //spriteBatch.DrawString(font, gX, new Vector2(750, 50), Color.Blue);
           // spriteBatch.DrawString(font, gY, new Vector2(750, 100), Color.Blue);
               if (playerlife <= 5) 
                  {
                   case1 = "Game over !";  
                   ScreenManager.Instance.AddScreen(new GameoverScreen());             
                  }
            spriteBatch.DrawString(font, Colision, new Vector2(750, 150), Color.Blue);
            if (case1 != "") spriteBatch.DrawString(font, case1, new Vector2(750, 200), Color.Blue);
            spriteBatch.DrawString(font, "Enemy killed:" + enemyHeroes.ToString(), new Vector2(750, 300), Color.Blue);
             
        }

     
    }
}


