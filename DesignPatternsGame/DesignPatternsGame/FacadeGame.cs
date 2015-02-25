namespace DesignPatternsGame
{
    using DesignPatternsGame.Common;
    using DesignPatternsGame.Facade;
    using DesignPatternsGame.Strategy;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using System;
    using System.ComponentModel.Composition;

    [Export(typeof(BaseGame))]
    public class FacadeGame : BaseGame
    {
        private FouluFacade fouluFacade;
        private GameSprite character;

        public FacadeGame()
        {
            fouluFacade = new FouluFacade(Content, "Foulu", new Vector2(20, 20));
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += FacadeGame_CustomDrawing;

            character = fouluFacade.AssemblyCharacter();
        }

        protected override void Update(GameTime gameTime)
        {
            character.Move(Controller1);

            base.Update(gameTime);
        }

        void FacadeGame_CustomDrawing(GameTime gameTime)
        {
            character.Draw(gameTime, SpriteBatch);
        }
    }
}
