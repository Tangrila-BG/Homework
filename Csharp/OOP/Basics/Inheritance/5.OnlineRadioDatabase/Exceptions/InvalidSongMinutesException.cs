using System;

namespace Csharp.OOP.Basics.Inheritance._5.OnlineRadioDatabase.Exceptions
{

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

}
