using DesingPatternsGame.Bridge;
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
    public class BridgeGame : BaseGame
    {
        private Foulu fouLu;

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += ObserverGame_CustomDrawing;

            fouLu = new Foulu(Content.Load<Texture2D>("Foulu"), new Vector2(40, 100));
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                if (fouLu.MoveStrategy.GetType() != typeof(RunStrategy))
                    fouLu.MoveStrategy = new RunStrategy();
            }
            else
            {
                if (fouLu.MoveStrategy.GetType() != typeof(WalkStrategy))
                    fouLu.MoveStrategy = new WalkStrategy();
            }

            fouLu.Move(Controller1);

            base.Update(gameTime);
        }

        void ObserverGame_CustomDrawing(GameTime gameTime)
        {
            fouLu.Draw(gameTime, SpriteBatch);
        }
    }
}
