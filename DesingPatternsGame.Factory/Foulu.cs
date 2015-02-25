using DesingPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.Factory
{
    public class Foulu : GameSprite
    {
        public Foulu(ContentManager content)
            : base(content.Load<Texture2D>("Foulu"), Vector2.Zero)
        {
            Animation = new Animation(300, 48, 48, 5, offsetY: 48);
        }
    }
}
