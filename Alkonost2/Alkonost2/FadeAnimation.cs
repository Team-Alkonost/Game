using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Alkonost2
{
    public class FadeAnimation : Animation
    {
        protected bool increase;
        protected float fadeSpeed;
        protected TimeSpan defaultTime, timer;
        protected bool startTimer;
        protected float activateValue;
        protected bool stopUpdating;
        protected float defaultAlpha;

        public TimeSpan Timer
        {
            get { return this.timer; }
            set { this.timer = value; }
        }

        public float FadeSpeed
        {
            get { return this.fadeSpeed; }
            set { this.fadeSpeed = value; }
        }

        public override float Alpha
        {
            get
            {
                return this.alpha;
            }
            set
            {
                if (this.alpha == 1.0f)
                    increase = false;
                else if (this.alpha == 0.0f)
                    increase = true;
                this.alpha = value;
            }
        }

        public float ActiveteValue
        {
            get { return this.activateValue; }
            set { this.activateValue = value; }
        }

        public override void LoadContent(ContentManager Content, Texture2D image,
            string text, Vector2 position)
        {
            base.LoadContent(Content, image, text, position);
            increase = false;
            fadeSpeed = 1.0f;
            defaultTime = new TimeSpan(0, 0, 1);
            timer = defaultTime;
            activateValue = 0.0f;
            stopUpdating = false;
            defaultAlpha = alpha;
        }

        public override void Update(GameTime gameTime)
        {
            if (isActive)
            {
                if (!stopUpdating)
                {
                    if (!increase)
                    {
                        alpha -= fadeSpeed = (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }
                    else
                    {
                        alpha += fadeSpeed = (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }
                    if (alpha <= 0.0f)
                    {
                        alpha = 0.0f;
                    }
                    else if (alpha >= 1.0f)
                    {
                        alpha = 1.0f;
                    }
                }
                if (alpha == activateValue)
                {
                    stopUpdating = true;
                    timer -= gameTime.ElapsedGameTime;
                    if (timer.TotalSeconds <= 0)
                    {
                        increase = !increase;
                        timer = defaultTime;
                        stopUpdating = false;
                    }
                }
            }
            else
            {
                alpha = defaultAlpha;
            }
        }
    }
}