using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public abstract class BluRayDiscEU : Disc
    {
        public BluRayDiscEU(string name, IPlayList playList) : base(name, playList)
        {
        }

        public abstract void Start();
    }
}
