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
using DesingPatternsGame.Strategy;
using DesingPatternsGame.Common;
using System.ComponentModel.Composition;
using DesingPatternsGame.Decorator;

namespace DesingPatternsGame
{
    [Export(typeof(BaseGame))]
    public class DecoratorGame : BaseGame
    {
        private GameSprite character;

        public DecoratorGame()
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += DecoratorGame_CustomDrawing;

            character = new GameSprite(Content.Load<Texture2D>("Foulu"), Vector2.Zero);
            character.Animation = new Animation(100, 48, 48, 5, offsetY: 48);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.X == ButtonState.Pressed)
            {
                character = new GameSpriteSlowDecorator(character);
            }
            else if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                character = new GameSpriteFastDecorator(character);
            }

            character.Move(Controller1);

            base.Update(gameTime);
        }

        void DecoratorGame_CustomDrawing(GameTime gameTime)
        {
            character.Draw(gameTime, SpriteBatch);
        }
    }
}
