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
    public class ScreenManeger
    {
        #region Variables

        /// <summary>
        /// Screenmaneger Instance
        /// </summary>

        private static ScreenManeger instance;
        /// <summary>
        /// Creating custom contentManeger
        /// </summary>

        ContentManager content;

        GameScreen currentScreen;

        GameScreen newScreen;

        /// <summary>
        /// Storing the GameScreen 
        /// </summary>

        Dictionary<string, GameScreen> screens = new Dictionary<string, GameScreen>();

        /// <summary>
        /// Screen Stack
        /// </summaruy>

        Stack<GameScreen> screenStack = new Stack<GameScreen>();

        /// <summary>
        /// Screen width and height 
        /// </summary>


        Vector2 dimentions;
        /// <summary>
        /// Let's us know if we should transition or not
        /// </summary>
        bool transition;

        FadeAnimation fade = new FadeAnimation();
        Texture2D fadeTexture;

        #endregion

        #region Properties

        public static ScreenManeger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManeger();
                }
                return instance;
            }
        }

        public Vector2 Dimensions
        {
            get { return this.dimentions; }
            set { this.dimentions = value; }
        }

        #endregion

        #region MainMethods 

        public void AddScreen(GameScreen screen)
        {
            transition = true;
            newScreen = screen;
            fade.IsActive = true;
            fade.Alpha = 0.0f;
            fade.ActiveteValue = 1.0f;
        }

        public void Initialize()
        {
            currentScreen = new SplashScreen();
            fade = new FadeAnimation();  //new2
        }

        public void LoadContent(ContentManager Content)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent(Content);
            fadeTexture = content.Load<Texture2D>("Und");
            fade.LoadContent(content, fadeTexture, "", Vector2.Zero);
            fade.Scale = dimentions.X;
        }

        public void Update(GameTime gameTime)
        {
            if (!transition)
            {
                currentScreen.Update(gameTime);
            }
            else
            {
                Transition(gameTime);  //2
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
            if (transition) //2
            {
                fade.Draw(spriteBatch); //2
            }
        }

        #endregion

        #region PrivateMethods
        private void Transition(GameTime gameTime)
        {
            fade.Update(gameTime);
            if (fade.Alpha == 1.0f && fade.Timer.TotalSeconds == 1.0f)
            {
                screenStack.Push(newScreen);
                currentScreen.UnloadContent();
                currentScreen = newScreen;
                currentScreen.LoadContent(content);
            }
            else if (fade.Alpha == 0.0f)
            {
                transition = false;
                fade.IsActive = false;
            }
        }
        #endregion
    }
}