namespace Examples.Structural.Bridge
{
    public abstract class SongPlayer
    {
        public string Name { get; }

        protected IPlayList PlayList { get; }

        public SongPlayer(string name, IPlayList playList)
        {
            Name = name;
            PlayList = playList;
        }

        public abstract void Play();
    }
}