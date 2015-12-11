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
       // private static object instance;

        #endregion

        #region Properties

      public static ScreenManeger Instance
        {                 
            get
            {
                if (instance == null) instance = new ScreenManeger();
                return instance;
            }

        }

        public Vector2 Dimensions 
        {
            get  {return dimentions; }
            set { dimentions = value; }
        }

        #endregion

        #region MainMethods 


        public void AddScreen(GameScreen screen) 
        {
            newScreen = screen;
            screenStack.Push(screen);
            currentScreen.UnloadContent();
            currentScreen = newScreen;
            currentScreen.LoadContent(content);
        }

        public void Initialize() 
        {
            currentScreen = new SplashScreen();
        }
        public void LoadContent(ContentManager Content)
        {
            content = new ContentManager(Content.ServiceProvider,"Content");
            currentScreen.LoadContent(Content);
        }
        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime); 
        }
        public void Draw(SpriteBatch spriteBatch) 
        {
            currentScreen.Draw(spriteBatch); 
        }

        #endregion

        
    }
}
