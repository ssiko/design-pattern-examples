using System;

namespace Examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Type the name of the pattern demo you want to run (i.e. Strategy, TemplateMethod, etc): ");
            DemoBase demo = new DemoCreator().Create(Console.ReadLine());
            demo.Run();
        }
    }
}
