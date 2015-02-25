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
using DesingPatternsGame.Common;

namespace DesingPatternsGame.Mediator
{
    public class GameSpriteMediator
    {
        public delegate void MovingEvent(GamePadState gamePadState);
        public event MovingEvent OnMoving;

        public void NotifyMoving(GamePadState gamePadState)
        {
            if (OnMoving != null)
                OnMoving(gamePadState);
        }
    }
}
