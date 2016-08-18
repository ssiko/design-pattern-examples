using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public class GodfatherBR: BluRayDisc
    {
        public GodfatherBR() : base("The Godfather - BluRay", new GodfatherContents())
        {
        }

        public override void Play()
        {
            Console.WriteLine($"Playing a Blu-ray Disc:\n\n{Name}\n\n");

            foreach (Item item in PlayList.GetItems() ?? Enumerable.Empty<Item>())
            {
                Console.WriteLine($"Chapter {item.Title}\n {item.Content}\n\n");
            }
        }
    }
}
