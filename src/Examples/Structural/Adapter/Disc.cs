using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public abstract class Disc
    {
        public string Name { get; }

        protected IPlayList PlayList { get; }

        public Disc(string name, IPlayList playList)
        {
            Name = name;
            PlayList = playList;
        }
    }
}
