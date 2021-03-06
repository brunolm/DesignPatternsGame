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

namespace DesignPatternsGame
{
    [Export]
    [Export(typeof(BaseGame))]
    [Export(typeof(ObserverGame))]
    public class ObserverGame : BaseGame
    {
        private DesignPatternsGame.Observer.Foulu fouLu;
        private DesignPatternsGame.Observer.Follower follower;

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += ObserverGame_CustomDrawing;

            fouLu = new DesignPatternsGame.Observer.Foulu(Content.Load<Texture2D>("Foulu"), new Vector2(40, 100));
            follower = new DesignPatternsGame.Observer.Follower(Content.Load<Texture2D>("Ryu"), new Vector2(0, 100));
            
            fouLu.Animation = new Animation(250, 48, 48, 5, offsetY: 48);
            follower.Animation = new Animation(250, 48, 48, 5, offsetY: 48);

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
