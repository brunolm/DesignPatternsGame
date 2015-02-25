using DesignPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.AbstractFactory
{
    public class GreenGooFactory : IEnemyFactory
    {
        public Common.GameSprite Create(ContentManager content, Vector2 spritePosition)
        {
            return new GreenGoo(content.Load<Texture2D>("MorphGoo"), spritePosition);
        }
    }
}
