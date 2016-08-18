using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public abstract class Disc
    {
        public string Type { get; }

        public string Name { get; }

        protected IPlayList PlayList { get; }

        public Disc(string type, string name, IPlayList playList)
        {
            Type = type;
            Name = name;
            PlayList = playList;
        }

        public abstract void Play();
    }
}
