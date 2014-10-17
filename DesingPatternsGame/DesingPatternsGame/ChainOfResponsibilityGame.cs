using DesingPatternsGame.ChainOfResponsibility;
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
    public class ChainOfResponsibilityGame : BaseGame
    {
        private NormalCharger normalCharger;
        private UltraCharger ultraCharger;
        private Megaman character;

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += ChainOfResponsibilityGame_CustomDrawing;

            this.character = new Megaman(Content.Load<Texture2D>("Megaman"), new Vector2(40, 100));

            this.normalCharger = new NormalCharger(character);
            this.ultraCharger = new UltraCharger(character);
            
            this.normalCharger.Next = this.ultraCharger;
        }

        protected override void Update(GameTime gameTime)
        {
            this.character.Move(Controller1);

            base.Update(gameTime);
        }

        double elapsed = 0;
        void ChainOfResponsibilityGame_CustomDrawing(GameTime gameTime)
        {
            elapsed += gameTime.ElapsedGameTime.TotalMilliseconds;

            this.normalCharger.Charge(SpriteBatch, gameTime, elapsed);

            if (elapsed > 15000)
            {
                elapsed = 0;
            }
        }
    }
}
