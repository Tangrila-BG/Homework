using System;
using Csharp.OOP.Basics.Inheritance._5.OnlineRadioDatabase.Exceptions;

namespace Csharp.OOP.Basics.Inheritance._5.OnlineRadioDatabase
{
    public static partial class _5OnlineRadioDatabase
    {
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

            private void SetLength(string length)
            {
                String[] lengthTokens = length.Split(':');

                int minutes;
                int seconds;

                try
                {
                    minutes = int.Parse(lengthTokens[0]);
                    seconds = int.Parse(lengthTokens[1]);
                }
                catch (Exception)
                {
                    throw new InvalidSongLengthException();
                }

                this.Minutes = minutes;
                this.Seconds = seconds;
            }

            public Song(string artistName, string songName, string length)
            {
                this.Artist = artistName;
                this.Name = songName;
                this.SetLength(length);
            }
        }
    }
}
