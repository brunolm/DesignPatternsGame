using Microsoft.Xna.Framework;
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

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
