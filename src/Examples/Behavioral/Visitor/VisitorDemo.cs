using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.Visitor
{
    public class VisitorDemo : DemoBase
    {
        public override void Run()
        {
            Console.WriteLine("Create the 'Simple Demo Board'...");
            ShapeBoard board = new Visitor.ShapeBoard { Name = "Simple Demo Board" };

            Console.WriteLine("Initializing 'Simple Demo Board' with 50 shapes...");
            board.FillBoard(50);

            Console.WriteLine("Analyzing 'Simple Demo Board' for shape counts...");
            SimpleCounterVisitor visitor = new SimpleCounterVisitor();
            board.RunBoard(visitor);

            Console.WriteLine("Summarizing 'Simple Demo Board' analysis...");
            Console.WriteLine(visitor.SummarizeCounts());

            WaitForUser();
        }
    }
}
