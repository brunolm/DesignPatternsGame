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
using DesignPatternsGame.Singleton;

namespace DesignPatternsGame
{
    [Export(typeof(BaseGame))]
    public class SingletonGame : BaseGame
    {
        private Foulu character;

        public SingletonGame()
        {
            Foulu.Content = Content;
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += SingletonGame_CustomDrawing;

            character = Foulu.Instance;
            //character = new Foulu(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            character.Move(Controller1);

            base.Update(gameTime);
        }

        void SingletonGame_CustomDrawing(GameTime gameTime)
        {
            character.Draw(gameTime, SpriteBatch);
        }
    }
}
