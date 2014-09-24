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

namespace DesingPatternsGame
{
    public class ObserverGame : BaseGame
    {
        private DesingPatternsGame.Observer.Foulu fouLu;
        private DesingPatternsGame.Observer.Follower follower;

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += ObserverGame_CustomDrawing;

            fouLu = new DesingPatternsGame.Observer.Foulu(Content.Load<Texture2D>("Foulu"), new Vector2(40, 0));
            follower = new DesingPatternsGame.Observer.Follower(Content.Load<Texture2D>("Ryu"), new Vector2(0, 0));
            
            fouLu.Animation = new Animation(250, 48, 48, 5);
            follower.Animation = new Animation(250, 48, 48, 5, 0, 0);

            fouLu.Subscribe(follower);
        }

        protected override void Update(GameTime gameTime)
        {
            fouLu.Move(Controller1);

            base.Update(gameTime);
        }

        void ObserverGame_CustomDrawing(GameTime gameTime)
        {
            fouLu.Draw(gameTime, SpriteBatch);
            follower.Draw(gameTime, SpriteBatch);
        }
    }
}
