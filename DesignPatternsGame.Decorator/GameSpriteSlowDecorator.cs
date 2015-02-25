namespace DesignPatternsGame.Decorator
{
    using DesignPatternsGame.Common;
    using Microsoft.Xna.Framework;

    public class GameSpriteSlowDecorator : GameSpriteDecorator
    {
        public GameSpriteSlowDecorator(GameSprite gameSprite)
            : base(gameSprite)
        {

        }

        public override uint SpeedRatio
        {
            get
            {
                return base.SpeedRatio - 1;
            }
            set
            {
                base.SpeedRatio = value;
            }
        }
    }
}
