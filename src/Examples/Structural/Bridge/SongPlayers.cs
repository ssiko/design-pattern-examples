using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    public class PandoraSongPlayer : SongPlayer
    {
        public PandoraSongPlayer() : base("Pandora", new JamesPlayList())
        {
        }

        public override void Play()
        {
            Console.WriteLine($"Playing the following:\n\nName: {Name}\nPlay List: \"{PlayList.Title}\":\n");

            foreach(Song song in PlayList.GetSongs() ?? Enumerable.Empty<Song>())
            {
                Console.WriteLine($"\tPlaying Song: \"{song.Title}\" by {song.Artist}");
            }
        }
    }
}
