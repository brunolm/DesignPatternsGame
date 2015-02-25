using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.Common
{
    public class GameSprite
    {
        public Vector2 SpritePosition { get; set; }

        public virtual Animation Animation { get; set; }

        public Texture2D SpriteTexture { get; set; }

        public virtual uint SpeedRatio { get; set; }

        public GameSprite(Texture2D spriteTexture, Vector2 spritePosition)
        {
            SpriteTexture = spriteTexture;
            SpritePosition = spritePosition;
            SpeedRatio = 1;
        }

        public virtual void Move(GamePadState gamePadState)
        {
            SpritePosition += SpeedRatio * new Vector2(gamePadState.ThumbSticks.Left.X, 0);
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Animation.Draw(gameTime, spriteBatch, SpriteTexture, SpritePosition);
        }
    }
}
