using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.Common
{
    public abstract class GameSprite
    {
        public Vector2 SpritePosition { get; set; }

        public Animation Animation { get; set; }

        public Texture2D SpriteTexture { get; set; }

        public GameSprite(Texture2D spriteTexture, Vector2 spritePosition)
        {
            SpriteTexture = spriteTexture;
            SpritePosition = spritePosition;
        }

        public virtual void Move(GamePadState Controller1)
        {
            SpritePosition += 1 * new Vector2(Controller1.ThumbSticks.Left.X, -Controller1.ThumbSticks.Left.X);
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Animation.Draw(gameTime, spriteBatch, SpriteTexture, SpritePosition);
        }
    }
}
