using System;

namespace Csharp.OOP.Basics.Inheritance._5.OnlineRadioDatabase.Exceptions
{

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
