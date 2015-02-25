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
using DesignPatternsGame.Memento;

namespace DesignPatternsGame
{
    [Export(typeof(BaseGame))]
    public class MementoGame : BaseGame
    {
        private FouluRecorder recorder;
        private Foulu character;

        public MementoGame()
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += MementoGame_CustomDrawing;

            this.character = new Foulu(Content);
            this.recorder = new FouluRecorder(character);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.A == ButtonState.Pressed)
            {
                this.recorder.Record();
            }
            else if (Controller1.Buttons.X == ButtonState.Pressed)
            {
                this.recorder.Rewind();
            }
            else if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                this.recorder.Foward();
            }

            character.Move(Controller1);

            base.Update(gameTime);
        }

        void MementoGame_CustomDrawing(GameTime gameTime)
        {
            character.Draw(gameTime, SpriteBatch);
        }
    }
}
