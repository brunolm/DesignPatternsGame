using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.AbstractFactory
{
    public class Spawner
    {
        public IEnemyFactory EnemyFactory { get; set; }

        private ContentManager content;

        private Vector2 nextPoint = Vector2.Zero;

        private int totalSpawned = 0;

        public Spawner(ContentManager content)
        {
            this.content = content;

            EnemyFactory = new GreenGooFactory();
        }

        public Common.GameSprite Spawn()
        {
            var mod = totalSpawned % 15;
            nextPoint += totalSpawned == 0 ? Vector2.Zero : new Vector2(50, mod == 0 ? 50 : 0);

            if (mod == 0 && totalSpawned != 0)
                nextPoint = new Vector2(0, nextPoint.Y + 10);

            ++totalSpawned;

            return EnemyFactory.Create(this.content, this.nextPoint);
        }
    }
}
