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
using DesingPatternsGame.Proxy;

namespace DesingPatternsGame
{
    [Export(typeof(BaseGame))]
    public class ProxyGame : BaseGame
    {
        private FouluProxy proxy;
        private Foulu character;

        public ProxyGame()
        {
            this.proxy = new FouluProxy();
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += ProxyGame_CustomDrawing;
        }

        protected override void Update(GameTime gameTime)
        {
            if (character == null)
                character = proxy.Create(Content, gameTime);

            if (character != null)
            {
                character.Move(Controller1);

                base.Update(gameTime);
            }
        }

        void ProxyGame_CustomDrawing(GameTime gameTime)
        {
            if (character != null)
                character.Draw(gameTime, SpriteBatch);
        }
    }
}
