using DesignPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame
{
    public class GameMenu : BaseGame
    {
        private SpriteFont optionFont;

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += GameMenu_CustomDrawing;

            optionFont = Content.Load<SpriteFont>("Courier New");
        }

        void GameMenu_CustomDrawing(Microsoft.Xna.Framework.GameTime gameTime)
        {
            SpriteBatch.DrawString(optionFont, "Game name", Vector2.Zero, Color.White, 0, Vector2.Zero, 1.0f, SpriteEffects.None, 0.5f);
        }
    }
}
