using System;
using DesingPatternsGame.Bridge;
using DesingPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel.Composition;

namespace DesingPatternsGame
{
    [Export]
    [Export(typeof(BaseGame))]
    public class BridgeGame : BaseGame
    {
        private Foulu fouLu;

        private WalkController walkController = new WalkController();
        private RunController runController = new RunController();

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
                runController.Move(fouLu, Controller1);
            }
            else
            {
                walkController.Move(fouLu, Controller1);
            }

            base.Update(gameTime);
        }

        void ObserverGame_CustomDrawing(GameTime gameTime)
        {
            fouLu.Draw(gameTime, SpriteBatch);
        }
    }

    public interface IMoveCotroller
    {
        void Move(Foulu character, GamePadState gamePadState);
    }

    public class WalkController : IMoveCotroller
    {
        public void Move(Foulu character, GamePadState gamePadState)
        {
            if (character.MoveStrategy.GetType() != typeof(WalkStrategy))
                character.MoveStrategy = new WalkStrategy();

            character.Move(gamePadState);
        }
    }

    public class RunController : IMoveCotroller
    {
        public void Move(Foulu character, GamePadState gamePadState)
        {
            if (character.MoveStrategy.GetType() != typeof(RunStrategy))
                character.MoveStrategy = new RunStrategy();

            character.Move(gamePadState);
        }
    }
}
