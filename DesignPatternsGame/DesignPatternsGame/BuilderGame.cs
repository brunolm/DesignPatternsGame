using DesignPatternsGame.Builder;
using DesignPatternsGame.Common;
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
    [Export]
    [Export(typeof(BaseGame))]
    public class BuilderGame : BaseGame
    {
        private MainCharacterBuilder mainCharBuilder;
        private GameCharacter character;

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += BuilderGame_CustomDrawing;

            this.mainCharBuilder = new MainCharacterBuilder(Content);

            this.mainCharBuilder.BuildGod();

            this.character = mainCharBuilder.Result;
        }

        protected override void Update(GameTime gameTime)
        {
            if (Controller1.Buttons.A == ButtonState.Pressed)
            {
                this.mainCharBuilder.BuildGod();
                this.character = this.mainCharBuilder.Result;
            }
            else if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                this.mainCharBuilder.BuildRobot();
                this.character = this.mainCharBuilder.Result;
            }

            this.character.Move(Controller1);

            base.Update(gameTime);
        }

        void BuilderGame_CustomDrawing(GameTime gameTime)
        {
            this.character.Draw(gameTime, SpriteBatch);
        }
    }
}
