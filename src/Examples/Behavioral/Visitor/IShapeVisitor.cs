namespace Examples.Behavioral.Visitor
{
    public interface IShapeVisitor
    {
        void Visit(Circle circle);

        void Visit(Square square);

        void Visit(Triangle triangle);
    }
}