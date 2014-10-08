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

namespace DesingPatternsGame.Builder
{
    public class GameCharacter : GameSprite
    {
        public GameCharacter(Texture2D spriteTexture, Vector2 spritePosition)
            : base(spriteTexture, spritePosition)
        {
        }

        public override void Move(GamePadState Controller1)
        {
            SpritePosition += 2 * new Vector2(Controller1.ThumbSticks.Left.X, 0);
        }
    }
}
