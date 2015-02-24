using DesingPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.Command
{
    public class CreateRobotCommand : ICommand
    {
        public Common.GameSprite Execute(ContentManager content)
        {
            var zero = new Common.GameSprite(content.Load<Texture2D>("Zero"), Vector2.Zero);

            zero.Animation = new Animation(250, 48, 48, 9);

            return zero;
        }
    }
}
