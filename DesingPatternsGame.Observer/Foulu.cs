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

namespace DesingPatternsGame.Observer
{
    public class Foulu : GameSprite, IGodEmperor
    {
        private IList<IGodEmperorObserver> observers;

        public Foulu(Texture2D spriteTexture, Vector2 spritePosition)
            : base(spriteTexture, spritePosition)
        {
            this.observers = new List<IGodEmperorObserver>();
        }

        public void Subscribe(IGodEmperorObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Unsubscribe(IGodEmperorObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in this.observers)
            {
                item.Update(SpritePosition);
            }
        }


        public override void Move(GamePadState Controller1)
        {
            SpritePosition += 2 * new Vector2(Controller1.ThumbSticks.Left.X, SpritePosition.Y);
            Notify();
        }
    }
}
