using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
   public class CheckMood
    {
        public string AnalyseMood(string message)
        {
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
