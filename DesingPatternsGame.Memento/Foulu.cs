namespace DesingPatternsGame.Memento
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

    public class Foulu : GameSprite
    {
        public Foulu(ContentManager content)
            : base(content.Load<Texture2D>("Foulu"), Vector2.Zero)
        {
            Animation = new Animation(300, 48, 48, 5, offsetY: 48);
        }

        public Memento Memento
        {
            get
            {
                return new Memento { Position = SpritePosition };
            }
            set
            {
                SpritePosition = value.Position;
            }
        }
    }
}
