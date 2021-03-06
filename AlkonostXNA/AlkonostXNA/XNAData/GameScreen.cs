﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AlkonostXNAGame.XNAData
{
    public class GameScreen
    {
        protected ContentManager content;


        public virtual void LoadContent(ContentManager Content)
        {
         content = new ContentManager(Content.ServiceProvider,"Content");
        }
        public virtual void Initialize() 
        { 
        }
        
        public virtual void UnloadContent() 
        { 
            content.Unload();
        }
        public virtual void Update(GameTime gameTime) 
        {
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
