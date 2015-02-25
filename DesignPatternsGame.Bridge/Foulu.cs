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
using DesignPatternsGame.Common;

namespace DesignPatternsGame.Bridge
{
    public class Foulu : BridgeCharacter
    {
        public IMoveStrategy MoveStrategy { get; set; }

        public Foulu(Texture2D spriteTexture, Vector2 spritePosition)
            : base(spriteTexture, spritePosition)
        {
            MoveStrategy = new WalkStrategy();
        }

        public override void Move(GamePadState Controller1)
        {
            SpritePosition = MoveStrategy.Move(SpritePosition, Controller1);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            MoveStrategy.Draw(gameTime, spriteBatch, SpriteTexture, SpritePosition);
        }
    }
}
