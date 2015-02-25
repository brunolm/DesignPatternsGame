namespace DesignPatternsGame.Visitor
{
    using Microsoft.Xna.Framework;

    public class Boost : IVisitor
    {
        public void Visit<T>(IAccept<T> obj) where T : IVisitor
        {
            if (obj is Foulu)
            {
                var foulu = obj as Foulu;

                foulu.SpritePosition += new Vector2(1, 1);
            }
        }
    }
}
