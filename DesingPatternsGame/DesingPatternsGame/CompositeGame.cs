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
using DesingPatternsGame.Strategy;
using DesingPatternsGame.Common;
using System.ComponentModel.Composition;
using DesingPatternsGame.Composite;

namespace DesingPatternsGame
{
    [Export(typeof(BaseGame))]
    public class CompositeGame : BaseGame
    {
        private CompositeGameSprite gameSpriteComposition;

        public CompositeGame()
        {
            this.gameSpriteComposition = new CompositeGameSprite();
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            this.CustomDrawing += CompositeGame_CustomDrawing;

            this.gameSpriteComposition.Add(new MovableCharacter(Content.Load<Texture2D>("Foulu"), Vector2.Zero));
            this.gameSpriteComposition.Add(new MovableCharacter(Content.Load<Texture2D>("Foulu"), new Vector2(0, 60)));
            this.gameSpriteComposition.Add(new MovableCharacter(Content.Load<Texture2D>("Foulu"), new Vector2(0, 120)));
        }

        protected override void Update(GameTime gameTime)
        {
            this.gameSpriteComposition.Move(Controller1);

            base.Update(gameTime);
        }

        void CompositeGame_CustomDrawing(GameTime gameTime)
        {
            this.gameSpriteComposition.Draw(gameTime, SpriteBatch);
        }
    }
}
