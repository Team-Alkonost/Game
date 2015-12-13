using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Alkonost2.GameGraphic
{
    class DrawRectangle :  GameScreen
    {
        protected SpriteBatch spriteBatch;
        protected Texture2D dummyTexture;
        protected Rectangle dummyRectangle;
        protected Color Colori;
        protected GraphicsDeviceManager graphics;
        public int DrawOrder { get; set; }

    public void RectangleOverlay(Rectangle rect, Color colori, Game game)
    {
        // Choose a high number, so we will draw on top of other components.
        DrawOrder = 1000;
        dummyRectangle = rect;
        Colori = colori;
    }

   public override void LoadContent(ContentManager Content)
    {
         base.LoadContent(Content);      
         spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
         dummyTexture = new Texture2D(graphics.GraphicsDevice, 1, 1);
        dummyTexture.SetData(new Color[] { Color.White });
    }

   public override void Draw(SpriteBatch spriteBatche)
    {
        spriteBatch.Begin();
        spriteBatch.Draw(dummyTexture, dummyRectangle, Colori);
        spriteBatch.End();
    }

       public override void UnloadContent()
       {
           base.UnloadContent();
       }


       
    }
}
