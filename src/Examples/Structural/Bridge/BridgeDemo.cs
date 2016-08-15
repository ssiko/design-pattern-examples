using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Bridge
{
    public  class BridgeDemo : DemoBase
    {
        public override void Run()
        {
            SongPlayer player = new SongPlayer { Name = "Pandora" };
            player.PlayList = new JamesPlayList();
            player.Play();

            WaitForUser();
        }
    }
}
