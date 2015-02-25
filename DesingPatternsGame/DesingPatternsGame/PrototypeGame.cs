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
using DesingPatternsGame.Prototype;

namespace DesingPatternsGame
{
    [Export(typeof(BaseGame))]
    public class PrototypeGame : BaseGame
    {
        private Foulu character;
        private Foulu character2;

        public PrototypeGame()
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += PrototypeGame_CustomDrawing;

            character = new Foulu(Content);
            character2 = character.Clone();
            character2.SpritePosition += new Vector2(0, 60);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.A == ButtonState.Pressed)
            {
                character2.SpritePosition += new Vector2(2, 1);
            }

            character.Move(Controller1);

            base.Update(gameTime);
        }

        void PrototypeGame_CustomDrawing(GameTime gameTime)
        {
            character.Draw(gameTime, SpriteBatch);
            character2.Draw(gameTime, SpriteBatch);
        }
    }
}
