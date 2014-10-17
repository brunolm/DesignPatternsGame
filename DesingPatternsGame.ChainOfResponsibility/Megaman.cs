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
using DesingPatternsGame.Common;

namespace DesingPatternsGame.ChainOfResponsibility
{
    public class Megaman : GameSprite
    {
        public Megaman(Texture2D spriteTexture, Vector2 spritePosition)
            : base(spriteTexture, spritePosition)
        {
            //Animation = new Animation(250, 48, 72, 9);
        }
    }
}
