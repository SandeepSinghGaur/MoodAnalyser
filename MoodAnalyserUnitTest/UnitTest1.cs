using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;
using System.Diagnostics;

namespace MoodAnalyserUnitTest
{
    [TestClass]
    public class MoodTest
    {
        //<Summary>
        //Test Case 1.1 Using Without Constructor check SAD Mood
        //<Summary>
        [TestMethod]
        public void WhenSadMoodReturnSad()
        {
            CheckMood referenceMood = new CheckMood("I am in Sad Mood");
            string mood = referenceMood.AnalyseMood();
            Assert.AreEqual("SAD", mood);
        }
        //<Summary>
        //Test Case 1.2 Using Without Constructor check HAPPY Mood
        //<Summary>
        [TestMethod]
        public void WhenAnyMoodReturnHappy()
        {
            CheckMood referenceMood = new CheckMood("I am in Any Mood");
            string mood = referenceMood.AnalyseMood();
            Assert.AreEqual("HAPPY", mood);
        }
        //<Summary>
        //Test Case Refactor Use argumented Constructor and check SAD Mood
        //<Summary>
        [TestMethod]
        public void WhenSadMoodReturnSadUsingConstructor()
        {
            CheckMood referenceMood = new CheckMood("I am in Sad Mood");
            string mood = referenceMood.AnalyseMood();
            Assert.AreEqual("SAD", mood);
        }
        //<Summary>
        //Test Case Refactor Use argumented Constructor and check HAPPY Mood
        //<Summary>
        [TestMethod]
        public void WhenAnyMoodReturnHappyUsingConstructor()
        {
            CheckMood referenceMood = new CheckMood("I am in Any Mood");
            string mood = referenceMood.AnalyseMood();
            Assert.AreEqual("HAPPY", mood);
        }
        //<Summary>
        //Test Case 2.1 Given Invalid Mood Throw simple Exception
        //<Summary>
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
        //<Summary>
        //Test Case 3.1 Given Null Mood Throw MoodAnalysisException
        //<Summary>
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
        //<Summary>
        //Test Case 3.2 Given " "[Empty] Mood Throw MoodAnalysisException
        //<Summary>
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
        //<Summary>
        //Test Case 4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object
        //<summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserUnitTest.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
    }
}

       