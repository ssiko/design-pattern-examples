namespace Examples.Behavioral.Visitor
{
    public class Triangle : Shape
    {
        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}