using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public abstract class BluRayDiscUS : Disc
    {
        public BluRayDiscUS(string name, IPlayList playList) : base(name, playList)
        {
        }

        public abstract void Play();
    }
}
