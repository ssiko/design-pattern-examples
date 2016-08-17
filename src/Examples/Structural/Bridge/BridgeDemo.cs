namespace Examples.Structural.Bridge
{
    public class BridgeDemo : DemoBase
    {
        protected override void DoRun()
        {
            SongPlayer player = new PandoraSongPlayer();
            player.Play();
        }
    }
}