using DesingPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.ChainOfResponsibility
{
    public class NormalCharger : ChargerChain
    {
        private GameSprite character;
        private readonly Animation animation = new Animation(250, 48, 72, 7, 48 * 2, 0);

        public NormalCharger(GameSprite character)
        {
            this.character = character;
        }

        public override void Charge(SpriteBatch spriteBatch, GameTime gameTime, double elapsed)
        {
            if (elapsed < 7500)
            {
                this.animation.Draw(gameTime, spriteBatch, this.character.SpriteTexture, this.character.SpritePosition);
            }
            else
            {
                base.Charge(spriteBatch, gameTime, elapsed);
            }
        }
    }
}
