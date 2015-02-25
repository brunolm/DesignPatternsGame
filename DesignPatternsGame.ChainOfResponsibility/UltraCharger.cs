using DesignPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.ChainOfResponsibility
{
    public class UltraCharger : ChargerChain
    {
        private GameSprite character;

        private readonly Animation animation = new Animation(250, 48, 72, 9, 0, 72);

        public UltraCharger(GameSprite character)
        {
            this.character = character;
        }

        public override void Charge(SpriteBatch spriteBatch, GameTime gameTime, double elapsed)
        {
            if (elapsed < 15000)
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
