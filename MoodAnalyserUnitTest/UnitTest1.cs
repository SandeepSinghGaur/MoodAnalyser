using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;
using System.Diagnostics;

namespace MoodAnalyserUnitTest
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void WhenSadMoodReturnSad()
        {
            CheckMood referenceMood = new CheckMood("I am in Sad Mood");
            string mood = referenceMood.AnalyseMood();
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void WhenAnyMoodReturnHappy()
        {
            CheckMood referenceMood = new CheckMood("I am in Any Mood");
            string mood = referenceMood.AnalyseMood();
            Assert.AreEqual("HAPPY", mood);
        }

        [TestMethod]
        public void WhenSadMoodReturnSadUsingConstructor()
        {
            CheckMood referenceMood = new CheckMood("I am in Sad Mood");
            string mood = referenceMood.AnalyseMood();
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void WhenAnyMoodReturnHappyUsingConstructor()
        {
            CheckMood referenceMood = new CheckMood("I am in Any Mood");
            string mood = referenceMood.AnalyseMood();
            Assert.AreEqual("HAPPY", mood);
        }
        [TestMethod]
        public void WhenNullCatchException()
        {
            try
            {
                CheckMood moodAnalyser = new CheckMood(null);
                string mood = moodAnalyser.AnalyseMood();
                Assert.AreEqual("HAPPY", mood);
            }
            catch (NullReferenceException e)
            {
                Debug.WriteLine(e.ToString());
            }
        }
        [TestMethod]
        public void GivenSadMessageNull_WhenAnalyse_ShouldThrowException()
        {
            try
            {
                CheckMood moodAnalysis = new CheckMood(null);
                string mood = moodAnalysis.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.EnterNull, e.Type);
            }
        }
        [TestMethod]
        public void GivenSadMessageEmpty_WhenAnalyse_ShouldThrowException()
        {
            try
            {
                CheckMood moodAnalysis = new CheckMood(" ");
                string mood = moodAnalysis.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.EnterEmpty, e.Type);
            }
        }
    }
}

       