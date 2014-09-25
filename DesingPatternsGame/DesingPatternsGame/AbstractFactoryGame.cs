using DesingPatternsGame.AbstractFactory;
using DesingPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace DesingPatternsGame
{
    [Export(typeof(BaseGame))]

    public class AbstractFactoryGame : BaseGame
    {
        private IList<GameSprite> enemies = new List<GameSprite>();

        private Spawner spawner = null;

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += AbstractFactoryGame_CustomDrawing;

            spawner = new Spawner(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.A == ButtonState.Pressed)
            {
                spawner.EnemyFactory = new GreenGooFactory();
            }
            else if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                spawner.EnemyFactory = new RedGooFactory();
            }
            else if (Controller1.Buttons.X == ButtonState.Pressed)
            {
                spawner.EnemyFactory = new BlueGooFactory();
            }
            else if (Controller1.Buttons.Y == ButtonState.Pressed)
            {
                spawner.EnemyFactory = new BrownGooFactory();
            }

            if (Controller1.Buttons.RightShoulder == ButtonState.Pressed)
            {
                enemies.Add(spawner.Spawn());
            }

            base.Update(gameTime);
        }

        void AbstractFactoryGame_CustomDrawing(GameTime gameTime)
        {
            foreach (var item in enemies)
            {
                item.Draw(gameTime, SpriteBatch);
            }
        }
    }
}
