namespace DesingPatternsGame.Prototype
{
    using DesingPatternsGame.Common;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Foulu : GameSprite
    {
        public Foulu(ContentManager content)
            : base(content.Load<Texture2D>("Foulu"), Vector2.Zero)
        {
            Animation = new Animation(300, 48, 48, 5, offsetY: 48);
        }

        public Foulu Clone()
        {
            return (Foulu)this.MemberwiseClone();
        }
    }
}
