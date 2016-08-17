namespace Examples.Behavioral.Visitor
{
    public class Square : Shape
    {
        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}