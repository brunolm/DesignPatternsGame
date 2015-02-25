using DesignPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.ChainOfResponsibility
{
    public abstract class ChargerChain
    {
        public ChargerChain Next { get; set; }

        public virtual void Charge(SpriteBatch spriteBatch, GameTime gameTime, double elapsed)
        {
            if (Next != null)
                Next.Charge(spriteBatch, gameTime, elapsed);
        }
    }
}
