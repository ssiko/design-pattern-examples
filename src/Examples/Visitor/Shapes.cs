using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Visitor
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public abstract void Accept(IShapeVisitor visitor);
    }

    public class Circle : Shape
    {
        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Square : Shape
    {
        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Triangle : Shape
    {
        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
