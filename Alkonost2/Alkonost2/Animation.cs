﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace Alkonost2
{
    public class Animation
    {
        protected Texture2D image;
        protected string text;
        protected SpriteFont font;
        protected Color color;
        protected Rectangle sourceRect;
        protected float rotation, scale, axis;
        protected Vector2 origin, position;
        protected ContentManager content;
        protected bool isActive;
        protected float alpha;

        public virtual float Alpha
        {
            get { return this.alpha; }
            set { this.alpha = value; }
        }

        public float Scale
        {
            set { this.scale = value; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }

        public virtual void LoadContent(ContentManager Content, Texture2D image, string text,
            Vector2 position)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");
            this.image = image;
            this.text = text;
            this.position = position;

            if (text != String.Empty)
            {
                font = Content.Load<SpriteFont>("AnimationFont");
                color = new Color(114, 77, 255);
            }
            if (image != null)
            {
                sourceRect = new Rectangle(0, 0, image.Width, image.Height);
            }
            rotation = 0.0f;
            axis = 0.0f;
            this.scale = this.alpha = 1.0f;
            this.isActive = false;
        }

        public virtual void UnloadContent()
        {
            content.Unload();
            text = String.Empty;
            position = Vector2.Zero;
            sourceRect = Rectangle.Empty;
            image = null;
        }

        public virtual void Update(GameTime gameTime)
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (image != null)
            {
                origin = new Vector2(sourceRect.Width / 2, sourceRect.Height / 2);
                spriteBatch.Draw(image, position + origin, sourceRect,
                    Color.White * this.alpha, rotation, origin, this.scale,
                    SpriteEffects.None, 0.0f);
            }
            if (text != String.Empty)
            {
                origin = new Vector2(font.MeasureString(text).X / 2,
                    font.MeasureString(text).Y / 2);
                spriteBatch.DrawString(font, text, position + origin, color * this.alpha,
                    rotation, origin, this.scale,
                    SpriteEffects.None, 0.0f);
            }
        }
    }
}