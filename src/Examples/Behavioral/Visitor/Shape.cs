namespace Examples.Behavioral.Visitor
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public abstract void Accept(IShapeVisitor visitor);
    }
}