using System;
using System.Linq;

namespace Examples.Structural.Bridge
{
    public class PandoraSongPlayer : SongPlayer
    {
        public PandoraSongPlayer() : base("Pandora", new JamesPlayList())
        {
        }

        public override void Play()
        {
            Console.WriteLine($"Playing the following:\n\nName: {Name}\nPlay List: \"{PlayList.Title}\":\n");

            foreach (Song song in PlayList.GetSongs() ?? Enumerable.Empty<Song>())
            {
                Console.WriteLine($"\tPlaying Song: \"{song.Title}\" by {song.Artist}");
            }
        }
    }
}