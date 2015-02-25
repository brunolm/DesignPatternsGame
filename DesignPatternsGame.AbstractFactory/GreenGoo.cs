using DesignPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.AbstractFactory
{
    public class GreenGoo : GameSprite
    {
        public GreenGoo(Texture2D spriteTexture, Vector2 spritePosition)
            : base(spriteTexture, spritePosition)
        {
            Animation = new Animation(100, 48, 48, 27, 0, 48 * 2);
        }
    }
}
