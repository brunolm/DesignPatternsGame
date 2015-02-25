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
using DesignPatternsGame.State;

namespace DesignPatternsGame
{
    [Export(typeof(BaseGame))]
    public class StateGame : BaseGame
    {
        private Foulu character;

        public StateGame()
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += StateGame_CustomDrawing;

            character = new Foulu(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                if (character.State.GetType() != typeof(RunningState))
                    character.State = new RunningState();
            }
            else if (Controller1.Buttons.A == ButtonState.Pressed)
            {
                if (character.State.GetType() != typeof(WalkingState))
                    character.State = new WalkingState();
            }

            character.Move(Controller1);

            base.Update(gameTime);
        }

        void StateGame_CustomDrawing(GameTime gameTime)
        {
            character.Draw(gameTime, SpriteBatch);
        }
    }
}
