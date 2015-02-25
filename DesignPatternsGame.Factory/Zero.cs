using DesignPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.Factory
{
    public class Zero : GameSprite
    {
        public Zero(ContentManager content)
            : base(content.Load<Texture2D>("Zero"), Vector2.Zero)
        {
            Animation = new Animation(250, 48, 48, 9);
        }
    }
}
