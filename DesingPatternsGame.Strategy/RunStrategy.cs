using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.Strategy
{
    public class RunStrategy : IMoveStrategy
    {
        public Vector2 Move(Vector2 spritePosition, GamePadState controllerState)
        {
            return spritePosition + 7 * new Vector2(controllerState.ThumbSticks.Left.X, -controllerState.ThumbSticks.Left.Y);
        }
        int frame = 0;
        double delay = 250;
        double elapsed = 0;

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D texture, Vector2 position)
        {
            spriteBatch.Draw(texture, position, new Rectangle(48 * frame, 144 + 48, 48, 48), Color.White);

            elapsed += gameTime.ElapsedGameTime.TotalMilliseconds;

            if (elapsed > delay)
            {
                elapsed = 0;
                ++frame;

                if (frame >= 6)
                    frame = 0;
            }
        }
    }
}
