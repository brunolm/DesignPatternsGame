using DesignPatternsGame.Command;
using DesignPatternsGame.Common;
using DesignPatternsGame.Strategy;
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

namespace DesignPatternsGame
{
    [Export(typeof(BaseGame))]
    public class CommandGame : BaseGame
    {
        private GameSprite character;

        private ICommand creationCommand;

        private CreateGodCommand createGodCommand = new CreateGodCommand();
        private CreateRobotCommand createRobotCommand = new CreateRobotCommand();

        public CommandGame()
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += CommandGame_CustomDrawing;

            character = new GameSprite(Content.Load<Texture2D>("Foulu"), Vector2.Zero);
            creationCommand = createGodCommand;
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.A == ButtonState.Pressed)
            {
                creationCommand = createGodCommand;
            }
            else if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                creationCommand = createRobotCommand;
            }

            character = creationCommand.Execute(Content);

            base.Update(gameTime);
        }

        void CommandGame_CustomDrawing(GameTime gameTime)
        {
            character.Draw(gameTime, SpriteBatch);
        }
    }
}
