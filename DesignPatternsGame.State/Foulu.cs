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

    public class Foulu : GameSprite
    {
        public Foulu(ContentManager content)
            : base(content.Load<Texture2D>("Foulu"), Vector2.Zero)
        {
            State = new WalkingState();
        }

        public IMoveState State { get; set; }

        public override Animation Animation
        {
            get
            {
                return State.Animation;
            }
        }
    }
}
