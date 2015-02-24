namespace DesingPatternsGame.Decorator
{
    using DesingPatternsGame.Common;
    using Microsoft.Xna.Framework;

    public class GameSpriteFastDecorator : GameSpriteDecorator
    {
        public GameSpriteFastDecorator(GameSprite gameSprite)
            : base(gameSprite)
        {

        }
        public override uint SpeedRatio
        {
            get
            {
                return base.SpeedRatio + 1;
            }
            set
            {
                base.SpeedRatio = value;
            }
        }
    }
}
