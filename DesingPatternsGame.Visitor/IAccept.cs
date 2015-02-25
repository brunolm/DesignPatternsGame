namespace DesingPatternsGame.Visitor
{
    public interface IAccept<T> where T: IVisitor
    {
        void Accept(T boost);
    }
}
