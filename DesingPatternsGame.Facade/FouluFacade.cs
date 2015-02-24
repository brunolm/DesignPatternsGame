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

namespace DesingPatternsGame.Facade
{
    public class FouluFacade
    {
        private ContentManager content;
        private string textureName;
        private Vector2 position;

        public FouluFacade(ContentManager content, string textureName, Vector2 position)
        {
            this.content = content;
            this.textureName = textureName;
            this.position = position;
        }

        public GameSprite AssemblyCharacter()
        {
            return new GameSprite(this.content.Load<Texture2D>(this.textureName), this.position)
            {
                Animation = new Animation(300, 48, 48, 5, offsetY: 48)
            };
        }
    }
}
