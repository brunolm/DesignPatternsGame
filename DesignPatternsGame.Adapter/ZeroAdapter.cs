using DesignPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.Adapter
{
    public class ZeroAdapter : GameSprite
    {
        private Zero zero;

        public ZeroAdapter(Zero zero, Texture2D spriteTexture, Vector2 spritePosition)
            : base(spriteTexture, spritePosition)
        {
            this.zero = zero;
        }

        public override void Move(GamePadState Controller1)
        {
            zero.MoveDashing();

            // adapt values to match your game
            SpritePosition += 2 * new Vector2(Controller1.ThumbSticks.Left.X, 0);
        }
    }
}
