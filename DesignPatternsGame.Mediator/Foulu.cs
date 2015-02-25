using DesignPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.Mediator
{
    public class Foulu : GameSprite
    {
        private GameSpriteMediator mediator;

        public Foulu(ContentManager content, GameSpriteMediator mediator)
            : base(content.Load<Texture2D>("Foulu"), Vector2.Zero)
        {
            this.mediator = mediator;
            this.mediator.OnMoving += mediator_OnMoving;
            Animation = new Animation(300, 48, 48, 5, offsetY: 48);
        }

        private void mediator_OnMoving(GamePadState gamePadState)
        {
            this.Move(gamePadState);
        }

        public void CallFollowers(GamePadState gamePadState)
        {
            mediator.NotifyMoving(gamePadState);
        }
    }
}
