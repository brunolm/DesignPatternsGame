using DesingPatternsGame.Adapter;
using DesingPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace DesingPatternsGame
{
    [Export]
    [Export(typeof(BaseGame))]
    public class AdapterGame : BaseGame
    {
        private Foulu fouLu;
        private ZeroAdapter zero;

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += ObserverGame_CustomDrawing;

            fouLu = new Foulu(Content.Load<Texture2D>("Foulu"), new Vector2(40, 100));
            zero = new ZeroAdapter(new Zero(), Content.Load<Texture2D>("Zero"), new Vector2(40, 150));

            fouLu.Animation = new Animation(250, 48, 48, 5, offsetY: 48);
            zero.Animation = new Animation(250, 48, 48, 9);
        }

        protected override void Update(GameTime gameTime)
        {
            fouLu.Move(Controller1);
            zero.Move(Controller1);

            base.Update(gameTime);
        }

        void ObserverGame_CustomDrawing(GameTime gameTime)
        {
            fouLu.Draw(gameTime, SpriteBatch);
            zero.Draw(gameTime, SpriteBatch);
        }
    }
}
