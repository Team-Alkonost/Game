using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using AlkonostXNAGame.XNAData.CharacterAnimation;
using Microsoft.Xna.Framework.Media;

namespace AlkonostXNAGame.XNAData
{
    public class AlkonostGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Song song;

        public AlkonostGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1000;
            this.Window.Title = "Alkonost: Siren Of the Sky";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            ScreenManager.Instance.Initialize();
            ScreenManager.Instance.Dimensions = new Vector2(1366, 768);
            graphics.PreferredBackBufferHeight = 700;
            // graphics.PreferredBackBufferWidth = (int)ScreenManeger.Instance.Dimensions.X;
            // graphics.PreferredBackBufferWidth = (int)ScreenManeger.Instance.Dimensions.Y;
            graphics.ApplyChanges();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ScreenManager.Instance.LoadContent(Content);
            song = Content.Load<Song>("ABSTRACT_ATMOSPHERE");
            MediaPlayer.Play(song);

            // TODO: use this.Content to load your game content here


        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            Content.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            // TODO: Add your update logic here
            ScreenManager.Instance.Update(gameTime);
            base.Update(gameTime);
        }


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.WhiteSmoke);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            ScreenManager.Instance.Draw(spriteBatch);
            //spriteBatch.Draw(sprite.Texture, sprite.Position, sprite.SourceRect, Color.White, 0f, sprite.Origin, 1.0f, SpriteEffects.None, 0);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
