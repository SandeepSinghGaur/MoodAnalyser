using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserUnitTest
{
    class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE,
            NO_SUCH_FIELD,NO_SUCH_METHOD,
            NO_SUCH_CLASS,OBJECT_CREATION_ISSUE,
            EnterEmpty,EnterNull
        }
        public ExceptionType Type { get; set; }

        public MoodAnalyserException(ExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
