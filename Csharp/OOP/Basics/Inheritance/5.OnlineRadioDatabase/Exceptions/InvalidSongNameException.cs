﻿using System;

namespace Csharp.OOP.Basics.Inheritance._5.OnlineRadioDatabase.Exceptions
{

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

}
