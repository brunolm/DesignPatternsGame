namespace DesingPatternsGame.Factory
{
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
    using DesingPatternsGame.Common;

    public class GameSpriteFactory
    {
        private ContentManager content;

        public GameSpriteFactory(ContentManager content)
        {
            this.content = content;
        }

        public GameSprite Create<T>() where T : GameSprite
        {
            return Activator.CreateInstance(typeof(T), new[] { content }) as T;
        }
    }
}
