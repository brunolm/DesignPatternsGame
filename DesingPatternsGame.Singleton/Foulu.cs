namespace DesingPatternsGame.Singleton
{
    using DesingPatternsGame.Common;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Foulu : GameSprite
    {
        private static Foulu foulu;

        private Foulu(ContentManager content)
            : base(content.Load<Texture2D>("Foulu"), Vector2.Zero)
        {
            Animation = new Animation(300, 48, 48, 5, offsetY: 48);
        }

        public static ContentManager Content { get; set; }

        public static Foulu Instance
        {
            get
            {
                return foulu ?? (foulu = new Foulu(Content));
            }
        }
    }
}
