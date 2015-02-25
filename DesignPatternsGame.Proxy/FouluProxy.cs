using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.Proxy
{
    public class FouluProxy
    {
        public Foulu Create(ContentManager content, GameTime gameTime)
        {
            if (gameTime.TotalGameTime.TotalSeconds > 5)
                return new Foulu(content);

            return null;
        }
    }
}
