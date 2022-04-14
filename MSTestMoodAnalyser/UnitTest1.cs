using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser_Exceptions;

namespace MSTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "SAD";
            string message = " I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string mood = moodAnalyser.AnalyserMood();

            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        [DataRow("Iam in Happy Mood")]
        [DataRow(null)]
        public void GivenHappyShouldReturnHappy(string message)
        {
            string expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string mood = moodAnalyser.AnalyserMood();

            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void Given_Empty_Mood_Throw_Empty_Mood_Exception()
        {
            try
            {
                string message = " ";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyserMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood Should Not be Empty", e.Message);
            }
        }

        [TestMethod]
        public void Given_Null_Mood_Throw_Null_Mood_Exception()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyserMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood Should Not be Null", e.Message);
            }
        }
    }
}
