namespace MoodAnalyser
{
    public class CheckMood
    {
        public string message;
        public CheckMood() { }
        public CheckMood(object message)
        {
            this.message = (string)message;
        }
        public string AnalyseMood()
        {
            if (Equals("Sad", message))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}

