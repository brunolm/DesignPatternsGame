using DesingPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.Observer
{
    public class Follower : GameSprite, IGodEmperorObserver
    {
        public Follower(Texture2D spriteTexture, Vector2 spritePosition)
            : base(spriteTexture, spritePosition)
        {
            SpritePosition = spritePosition;
        }

        public void Update(Vector2 godPosition)
        {
            SpritePosition = new Vector2(godPosition.X - 40, SpritePosition.Y);
        }
    }
}
