using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
   public class CheckMood
    {
        private string message;
        public CheckMood() { }
        public CheckMood(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }
        public string AnalyseMood(string message)
        {
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
