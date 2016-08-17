using System;

namespace Examples.Behavioral.Visitor
{
    public class VisitorDemo : DemoBase
    {
        protected override void DoRun()
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
        }
    }
}