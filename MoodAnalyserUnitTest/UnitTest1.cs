using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserUnitTest
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void WhenSadMoodReturnSad()
        {
            CheckMood referenceMood = new CheckMood();
            string mood = referenceMood.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void WhenAnyMoodReturnHappy()
        {
            CheckMood referenceMood = new CheckMood();
            string mood = referenceMood.AnalyseMood("I am in Any Mood");
            Assert.AreEqual("HAPPY", mood);
        }
    }
}
