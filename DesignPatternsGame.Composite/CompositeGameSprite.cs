namespace DesignPatternsGame.Composite
{
    using DesignPatternsGame.Common;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using System.Collections.Generic;

    public class CompositeGameSprite : ICompositeMove
    {
        private List<GameSprite> composition = new List<GameSprite>();

        public void Add(GameSprite sprite)
        {
            this.composition.Add(sprite);
        }

        public void Move(GamePadState gamePadState)
        {
            foreach (var item in this.composition)
            {
                item.Move(gamePadState);
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (var item in this.composition)
            {
                item.Draw(gameTime, spriteBatch);
            }
        }
    }
}
