namespace DesignPatternsGame.State
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
    using DesignPatternsGame.Common;

    public class RunningState : IMoveState
    {
        private Common.Animation animation;

        public Common.Animation Animation
        {
            get
            {
                return animation ?? (animation = new Animation(100, 48, 48, 5, 0, 48 * 4));
            }
        }
    }
}
