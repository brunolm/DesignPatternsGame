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
using DesignPatternsGame.Strategy;
using DesignPatternsGame.Common;
using System.ComponentModel.Composition;
using DesignPatternsGame.Factory;

namespace DesignPatternsGame
{
    [Export(typeof(BaseGame))]
    public class FactoryGame : BaseGame
    {
        private GameSpriteFactory gameSpriteFactory;
        private GameSprite character;

        public FactoryGame()
        {
            this.gameSpriteFactory = new GameSpriteFactory(Content);
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += FactoryGame_CustomDrawing;

            character = this.gameSpriteFactory.Create<Foulu>();
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.A == ButtonState.Pressed)
            {
                character = this.gameSpriteFactory.Create<Foulu>();
            }
            else if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                character = this.gameSpriteFactory.Create<Zero>();
            }

            character.Move(Controller1);

            base.Update(gameTime);
        }

        void FactoryGame_CustomDrawing(GameTime gameTime)
        {
            character.Draw(gameTime, SpriteBatch);
        }
    }
}
