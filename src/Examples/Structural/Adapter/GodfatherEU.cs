using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public class GodfatherEU : BluRayDiscEU
    {
        public GodfatherEU() : base("The Godfather - BluRay", new GodfatherContents())
        {
        }

        public override void Start()
        {
            Console.WriteLine($"Playing a Blu-ray Disc:\n\n{Name}\n");
            Console.WriteLine("@@@ EU Edition @@@\n\n");

            foreach (Item item in PlayList.GetItems() ?? Enumerable.Empty<Item>())
            {
                Console.WriteLine($"Chapter {item.Title}\n {item.Content}\n\n");
            }
        }
    }
}
