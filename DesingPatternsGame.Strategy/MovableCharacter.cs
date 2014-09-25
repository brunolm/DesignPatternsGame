using DesingPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.Strategy
{
    public class MovableCharacter : GameSprite
    {
        public IMoveStrategy MoveStretegy { get; set; }

        public MovableCharacter(Texture2D spriteTexture, Vector2 spritePosition)
            : base(spriteTexture, spritePosition)
        {
            MoveStretegy = new WalkStrategy();
        }

        public override void Move(Microsoft.Xna.Framework.Input.GamePadState Controller1)
        {
            SpritePosition = this.MoveStretegy.Move(SpritePosition, Controller1);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            this.MoveStretegy.Draw(gameTime, spriteBatch, SpriteTexture, SpritePosition);
        }
    }
}
