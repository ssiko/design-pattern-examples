using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.Visitor
{
    public interface IShapeVisitor
    {
        void Visit(Circle circle);
        void Visit(Square square);
        void Visit(Triangle triangle);
    }

    public class SimpleCounterVisitor : IShapeVisitor
    {
        public int CircleCount { get; private set; }
        public int SquareCount { get; private set; }
        public int TriangleCount { get; private set; }

        public void Visit(Circle circle)
        {
            CircleCount++;
        }

        public void Visit(Square square)
        {
            SquareCount++;
        }

        public void Visit(Triangle triangle)
        {
            TriangleCount++;
        }

        public string SummarizeCounts()
        {
            return $"Here's the total count:\n\tCircles:\t{CircleCount}\n\tSquares:\t{SquareCount}\n\tTriangles:\t{TriangleCount}";
        }
    }
}
