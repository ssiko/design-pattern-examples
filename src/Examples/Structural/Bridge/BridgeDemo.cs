using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Bridge
{
    public  class BridgeDemo : DemoBase
    {
        protected override void DoRun()
        {
            SongPlayer player = new PandoraSongPlayer();
            player.Play();
        }
    }
}
