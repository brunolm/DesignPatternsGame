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

namespace DesingPatternsGame
{
    [Export(typeof(BaseGame))]
    public class StrategyGame : BaseGame
    {
        private MovableCharacter character;

        public StrategyGame()
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += StrategyGame_CustomDrawing;

            character = new MovableCharacter(Content.Load<Texture2D>("Foulu"), Vector2.Zero);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                if (character.MoveStretegy.GetType() != typeof(RunStrategy))
                    character.MoveStretegy = new RunStrategy();
            }
            else
            {
                if (character.MoveStretegy.GetType() != typeof(WalkStrategy))
                    character.MoveStretegy = new WalkStrategy();
            }

            character.Move(Controller1);

            base.Update(gameTime);
        }

        void StrategyGame_CustomDrawing(GameTime gameTime)
        {
            character.Draw(gameTime, SpriteBatch);
        }
    }
}
