namespace Examples.Behavioral.Visitor
{
    public class Circle : Shape
    {
        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}