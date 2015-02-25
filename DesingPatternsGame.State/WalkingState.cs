namespace DesingPatternsGame.State
{
    using DesingPatternsGame.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WalkingState : IMoveState
    {
        private Common.Animation animation;

        public Common.Animation Animation
        {
            get
            {
                return animation ?? (animation = new Animation(300, 48, 48, 5, offsetY: 48));
            }
        }
    }
}
