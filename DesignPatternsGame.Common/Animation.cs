using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace DesignPatternsGame.Common
{
    public class Animation
    {
        private double elapsed = 0;
        
        public int Frame { get; set; }

        public int Delay { get; set; }

        public int SpriteWidth { get; set; }

        public int SpriteHeight { get; set; }

        public int TotalFrames { get; set; }

        public int OffsetX { get; set; }

        public int OffsetY { get; set; }

        public Animation(int delay, int spriteWidth, int spriteHeight, int totalFrames, int offsetX = 0, int offsetY = 0)
        {
            Delay = delay;
            SpriteWidth = spriteWidth;
            SpriteHeight = spriteHeight;
            TotalFrames = totalFrames;
            OffsetX = offsetX;
            OffsetY = offsetY;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D texture, Vector2 position)
        {
            spriteBatch.Draw(texture, position, new Rectangle(OffsetX + SpriteWidth * Frame, OffsetY, SpriteWidth, SpriteHeight), Color.White);

            elapsed += gameTime.ElapsedGameTime.TotalMilliseconds;

            if (elapsed > Delay)
            {
                elapsed = 0;
                ++Frame;

                if (Frame > TotalFrames)
                    Frame = 0;
            }
        }
    }
}
