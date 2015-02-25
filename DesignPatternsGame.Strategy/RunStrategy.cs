using DesignPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.Strategy
{
    public class RunStrategy : IMoveStrategy
    {
        private Animation animation;

        public RunStrategy()
        {
            this.animation = new Animation(100, 48, 48, 5, 0, 48 * 4);
        }

        public Vector2 Move(Vector2 spritePosition, GamePadState controllerState)
        {
            return spritePosition + 7 * new Vector2(controllerState.ThumbSticks.Left.X, -controllerState.ThumbSticks.Left.Y);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D texture, Vector2 position)
        {
            this.animation.Draw(gameTime, spriteBatch, texture, position);
        }
    }
}
