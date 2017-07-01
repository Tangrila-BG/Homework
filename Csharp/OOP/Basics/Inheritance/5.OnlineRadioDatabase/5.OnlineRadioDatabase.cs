using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Inheritance._5.OnlineRadioDatabase
{
    public static class _5OnlineRadioDatabase
    {
        public static void Solution()
        {
            var radio = new RadioStation();
            radio.SongAdded += SongAdded;

            var nSongs = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < nSongs; i++)
            {
                try
                {
                    var songInfo = Console.ReadLine().Trim().Split(';');

                    var artistName = songInfo[0];
                    var songName = songInfo[1];

                    var time = songInfo[2]
                        .Split(':')
                        .Select(int.Parse)
                        .ToArray();

                    var minutes = time[0];
                    var seconds = time[1];

                    radio.AddSong(new Song(artistName, songName, minutes, seconds));

                }
                catch (RadioException re)
                {
                    Console.WriteLine(re.Message);
                }
            }

            Console.WriteLine(radio);

        }

        private static void SongAdded(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Song added.");
        }

        class RadioStation
        {
            public event EventHandler SongAdded;
            private List<Song> _playList;

            public void AddSong(Song song)
            {
                this._playList.Add(song);

                this.SongAdded(this, EventArgs.Empty);
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

        class Song
        {
            private string _artist;
            private string _name;
            private int _minutes;
            private int _seconds;

            public string Artist
            {
                get { return _artist; }
                set
                {
                    if (value.Length < 3 || value.Length > 20)
                        throw new InvalidArtistNameException();

                    _artist = value;
                }
            }

            public string Name
            {
                get { return _name; }
                set
                {
                    if (value.Length < 3 || value.Length > 20)
                        throw new InvalidSongNameException();

                    _name = value;
                }
            }

            public int Minutes
            {
                get { return _minutes; }
                set
                {
                    if (value < 0 || value > 14)
                        throw new InvalidSongMinutesException();

                    _minutes = value;
                }
            }

            public int Seconds
            {
                get { return _seconds; }
                set
                {
                    if (value < 0 || value > 59)
                        throw new InvalidSongSecondsException();

                    _seconds = value;
                }
            }

            public Song(string arist, string songName, int minutes, int second)
            {
                this.Artist = arist;
                this.Name = songName;
                this.Minutes = minutes;
                this.Seconds = second;
            }
        }

        [Serializable]
        abstract class RadioException : Exception
        {
            protected RadioException(string message) : base(message)
            {
            }
            protected RadioException(string message, Exception innterException) : base(message, innterException)
            {
            }
            protected RadioException()
            {
            }
        }

        [Serializable]
        class InvalidSongException : RadioException
        {
            public override string Message => "Invalid song.";

            public InvalidSongException(string message) : base(message)
            {
            }
            public InvalidSongException(string message, Exception innterException) : base(message, innterException)
            {
            }
            public InvalidSongException()
            {
            }
        }

        [Serializable]
        class InvalidArtistNameException : InvalidSongException
        {
            public override string Message => "Artist name should be between 3 and 20 symbols.";

            public InvalidArtistNameException(string message) : base(message)
            {
            }
            public InvalidArtistNameException(string message, Exception innterException) : base(message, innterException)
            {
            }
            public InvalidArtistNameException()
            {
            }
        }

        [Serializable]
        class InvalidSongNameException : InvalidSongException
        {
            public override string Message => "Song name should be between 3 and 30 symbols.";

            public InvalidSongNameException(string message) : base(message)
            {
            }
            public InvalidSongNameException(string message, Exception innterException) : base(message, innterException)
            {
            }
            public InvalidSongNameException()
            {
            }
        }

        [Serializable]
        class InvalidSongLengthException : InvalidSongException
        {
            public override string Message => "Invalid song length.";

            public InvalidSongLengthException(string message) : base(message)
            {
            }
            public InvalidSongLengthException(string message, Exception innterException) : base(message, innterException)
            {
            }
            public InvalidSongLengthException()
            {
            }
        }

        [Serializable]
        class InvalidSongMinutesException : InvalidSongLengthException
        {
            public override string Message => "Song minutes should be between 0 and 14.";

            public InvalidSongMinutesException(string message) : base(message)
            {
            }
            public InvalidSongMinutesException(string message, Exception innterException) : base(message, innterException)
            {
            }
            public InvalidSongMinutesException()
            {
            }
        }

        [Serializable]
        class InvalidSongSecondsException : InvalidSongLengthException
        {
            public override string Message => "Song seconds should be between 0 and 59.";

            public InvalidSongSecondsException(string message) : base(message)
            {
            }
            public InvalidSongSecondsException(string message, Exception innterException) : base(message, innterException)
            {
            }
            public InvalidSongSecondsException()
            {
            }
        }
    }
}
