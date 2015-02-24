namespace DesingPatternsGame.Decorator
{
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
    using System.Linq;

    public class GameSpriteDecorator : GameSprite
    {
        public GameSpriteDecorator(GameSprite gameSprite)
            : base(gameSprite.SpriteTexture, gameSprite.SpritePosition)
        {
            Animation = gameSprite.Animation;
            SpeedRatio = gameSprite.SpeedRatio;
        }
    }
}
