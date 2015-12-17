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
        KnightAnimation player;
        KeyboardState keyState;

        Map map;
        SpriteFont font;

        public ScreenMap()
        {
            map = new Map();
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            player = new KnightAnimation(content.Load<Texture2D>("Sprites/SpriteSheet"), 1, 32, 48);
            player.Position = new Vector2(400, 300);
            Tiles.Content = content; //map class
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
            player.HandleSpriteMovement(gameTime);
            //exit from this window
            if (keyState.IsKeyDown(Keys.Z)) ScreenManager.Instance.AddScreen(new SplashScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch);
            spriteBatch.Draw(player.PlayerTexture, player.Position, player.SourceRect, Color.White, 0f, player.Origin, 1.0f, SpriteEffects.None, 0);
            float g = player.Position.X;
            string h = g.ToString();
            float g2 = player.Position.Y;
            string h2 = g2.ToString();

            if (player.Position.X == 354 && player.Position.Y == 354)
            {
                spriteBatch.DrawString(font, "Collision", new Vector2(750, 150), Color.Blue);
            }

            spriteBatch.DrawString(font, h, new Vector2(750, 50), Color.Blue);
            spriteBatch.DrawString(font, h2, new Vector2(750, 100), Color.Blue);
        }
    }
}
