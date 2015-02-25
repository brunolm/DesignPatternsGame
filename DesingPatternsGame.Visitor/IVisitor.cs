namespace DesingPatternsGame.Visitor
{
    public interface IVisitor
    {
        void Visit<T>(IAccept<T> obj) where T : IVisitor;
    }
}
