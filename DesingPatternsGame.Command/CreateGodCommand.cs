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
    public class CreateGodCommand : ICommand
    {
        public Common.GameSprite Execute(ContentManager content)
        {
            var fouLu = new Common.GameSprite(content.Load<Texture2D>("Foulu"), Vector2.Zero);

            fouLu.Animation = new Animation(250, 48, 48, 5, offsetY: 48);

            return fouLu;
        }
    }
}
