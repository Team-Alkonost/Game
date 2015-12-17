using AlkonostXNAGame.Config;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
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

        public KeyboardState KeyboardState
        {
            get
            {
                return Keyboard.GetState();
            }
        }

        public bool IsKeyPressed(Keys key)
        {
            bool isKeyPressed = KeyboardState.IsKeyDown(key);

            return isKeyPressed;
        }

        public bool AnyButtonsPressed()
        {
            if (this.KeyboardState.GetPressedKeys().Length > 0)
            {
                return true;
            }

            return false;
        }
    }
}