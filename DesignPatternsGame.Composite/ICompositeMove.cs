namespace DesignPatternsGame.Composite
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface ICompositeMove
    {
        void Move(GamePadState gamePadState);

        void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}
