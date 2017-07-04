using System;

namespace Csharp.OOP.Basics.Inheritance._5.OnlineRadioDatabase.Exceptions
{

    [Serializable]
    public abstract class RadioException : Exception
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

}
