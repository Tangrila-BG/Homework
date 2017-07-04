using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp.OOP.Basics.Inheritance._5.OnlineRadioDatabase.Exceptions;

namespace Csharp.OOP.Basics.Inheritance._5.OnlineRadioDatabase
{
    public static partial class _5OnlineRadioDatabase
    {
        public static void Solution()
        {
            var radio = new RadioStation();

            var nSongs = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < nSongs; i++)
            {
                try
                {
                    var songInfo = Console.ReadLine().Trim().Split(';');

                    var artistName = songInfo[0];
                    var songName = songInfo[1];

                    var length = songInfo[2];

                    radio.AddSong(new Song(artistName, songName, length));

                }
                catch (RadioException re)
                {
                    Console.WriteLine(re.Message);
                }
            }

            Console.WriteLine(radio);

        }
    }
}
