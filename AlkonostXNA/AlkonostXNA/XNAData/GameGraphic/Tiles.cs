﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AlkonostXNAGame.XNAData.GameGraphic
{
     class Tiles
    {
        protected Texture2D texture;
        private Rectangle rectangle;

        public Rectangle Rectangle 
        {
            get {return rectangle; }
            protected set { rectangle = value;  }
        }

        private static ContentManager content;
        public static ContentManager Content 
        {
            protected get { return content; }
             set { content = value; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);

        }

       

    }

    class CollisionsTiles : Tiles 
    {
        public CollisionsTiles(int i, Rectangle newRectangle)
        {
            texture = Content.Load<Texture2D>("Sprites/tile" + i);
            this.Rectangle = newRectangle;
        }
    }

}
