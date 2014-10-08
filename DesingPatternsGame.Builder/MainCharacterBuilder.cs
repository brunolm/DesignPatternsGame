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

namespace DesingPatternsGame.Builder
{
    public class MainCharacterBuilder
    {
        private ContentManager content;

        public GameCharacter Result { get; private set; }

        public MainCharacterBuilder(ContentManager content)
        {
            this.content = content;
        }

        public void BuildGod()
        {
            Result = new GameCharacter(content.Load<Texture2D>("Foulu"), new Vector2(40, 100));
            Result.Animation = new Animation(250, 48, 48, 5, offsetY: 48);
        }

        public void BuildRobot()
        {
            Result = new GameCharacter(content.Load<Texture2D>("Zero"), new Vector2(40, 100));
            Result.Animation = new Animation(250, 48, 48, 9);
        }
    }
}
