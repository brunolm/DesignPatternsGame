using DesignPatternsGame.Common;
using DesignPatternsGame.Visitor;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel.Composition;

namespace DesignPatternsGame
{
    [Export(typeof(BaseGame))]
    public class VisitorGame : BaseGame
    {
        private Foulu character;

        public VisitorGame()
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += VisitorGame_CustomDrawing;

            character = new Foulu(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                character.Accept(new Boost());
            }

            character.Move(Controller1);

            base.Update(gameTime);
        }

        void VisitorGame_CustomDrawing(GameTime gameTime)
        {
            character.Draw(gameTime, SpriteBatch);
        }
    }
}
