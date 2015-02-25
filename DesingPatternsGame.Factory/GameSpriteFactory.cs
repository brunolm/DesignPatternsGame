namespace DesingPatternsGame.Factory
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
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    public class GameSpriteFactory
    {
        private ContentManager content;

        private readonly ConcurrentDictionary<Type, GameSprite> cache = new ConcurrentDictionary<Type, GameSprite>();

        public GameSpriteFactory(ContentManager content)
        {
            this.content = content;
        }

        public GameSprite Create<T>() where T : GameSprite
        {
            return this.cache.GetOrAdd(typeof(T), (v) => Activator.CreateInstance(typeof(T), new[] { content }) as T);
        }
    }
}
