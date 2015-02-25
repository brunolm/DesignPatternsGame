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

namespace DesignPatternsGame.Strategy
{
    public interface IMoveStrategy
    {
        Vector2 Move(Vector2 spritePosition, GamePadState controllerState);

        void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D texture, Vector2 position);
    }
}
