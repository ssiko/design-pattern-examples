using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Bridge
{
    public class SongPlayer
    {
        public string Name { get; set; }

        public IPlayList PlayList { get; set; }

        public void Play()
        {
            if (PlayList == null)
                throw new InvalidOperationException("Your <PlayList> is missing.");

            Console.WriteLine($"Playing the following songs from \"{PlayList.Title}\":\n");

            foreach(Song song in PlayList.GetSongs() ?? Enumerable.Empty<Song>())
            {
                Console.WriteLine($"\tPlaying Song: \"{song.Title}\" by {song.Artist}");
            }
        }
    }
}
