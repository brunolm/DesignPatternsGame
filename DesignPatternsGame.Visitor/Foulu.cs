namespace DesignPatternsGame.Visitor
{
    using DesignPatternsGame.Common;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Foulu : GameSprite, IAccept<Boost>
    {
        public Foulu(ContentManager content)
            : base(content.Load<Texture2D>("Foulu"), Vector2.Zero)
        {
            Animation = new Animation(300, 48, 48, 5, offsetY: 48);
        }

        public void Accept(Boost boost)
        {
            boost.Visit(this);
        }
    }
}
