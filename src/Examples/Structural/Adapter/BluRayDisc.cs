using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public abstract class BluRayDisc : Disc
    {
        public BluRayDisc(string name, IPlayList playList) : base("Blu-ray", name, playList)
        {
        }
    }
}
