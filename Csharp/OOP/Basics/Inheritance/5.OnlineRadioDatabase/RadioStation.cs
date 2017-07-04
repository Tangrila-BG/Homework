using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.Inheritance._5.OnlineRadioDatabase
{
    public static partial class _5OnlineRadioDatabase
    {
        class RadioStation
        {
            private List<Song> _playList;

            public void AddSong(Song song)
            {
                this._playList.Add(song);

                Console.WriteLine("Song added.");
            }

            private int[] CalculatePlaylistLength()
            {
                var total = this._playList.Sum(x => x.Minutes * 60 + x.Seconds);
                var time = TimeSpan.FromSeconds(total);

                return new[] { time.Hours, time.Minutes, time.Seconds };
            }

            public override string ToString()
            {
                var length = this.CalculatePlaylistLength();

                return $"Songs added: {this._playList.Count}\n" +
                       $"Playlist length: {length[0]}h {length[1]}m {length[2]}s";
            }

            public RadioStation()
            {
                this._playList = new List<Song>();
            }
        }
    }
}
