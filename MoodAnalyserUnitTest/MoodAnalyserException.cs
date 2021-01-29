using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserUnitTest
{
    class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            EnterNull, EnterEmpty
        }
        public ExceptionType Type { get; set; }

        public MoodAnalyserException(ExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
