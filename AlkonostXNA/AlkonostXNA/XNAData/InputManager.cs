using AlkonostXNAGame.Config;
using Microsoft.Xna.Framework.Input;
using System;
using System.Linq;

namespace AlkonostXNAGame.XNAData
{
    internal class InputManager
    {
        private static InputManager instance;

        public static InputManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InputManager();
                }

                return instance;
            }
        }

        public void ExecuteOnKeyPressed(Keys key, Action methodToExecute)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            bool isKeyPressed = keyboardState.IsKeyDown(key);
            if (isKeyPressed)
            {
                methodToExecute();
            }
        }
    }
}