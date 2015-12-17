using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using AlkonostXNAGame.AlkonostDataStructure.Data;
using AlkonostXNAGame.XNAData.GameGraphic;
using AlkonostXNAGame.XNAData.CharacterAnimation;

namespace AlkonostXNAGame.XNAData
{
    class ScreenMap : GameScreen
    {
        Player player;
        KeyboardState keyState;

        Map map;
        SpriteFont font;

        public ScreenMap()
        {
            map = new Map();
            player = new Player();
        }

        public override void Initialize()
        {
            player.Initialize();
            base.Initialize();
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            Tiles.Content = content; //map class
            player.LoadContent(content);
            if (font == null)
            {
                font = content.Load<SpriteFont>("Font1");
            }

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
            player.Update(gameTime);
            //exit from this window
            if (keyState.IsKeyDown(Keys.Z)) ScreenManager.Instance.AddScreen(new SplashScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch);
            player.Draw(spriteBatch);
            float g = player.position.X;
            string h = g.ToString();
            float g2 = player.position.Y;
            string h2 = g2.ToString();

            if (player.position.X == 354 && player.position.Y == 354)
            {
                spriteBatch.DrawString(font, "Collision", new Vector2(750, 150), Color.Blue);
            }

            spriteBatch.DrawString(font, h, new Vector2(750, 50), Color.Blue);
            spriteBatch.DrawString(font, h2, new Vector2(750, 100), Color.Blue);
        }
    }
}
