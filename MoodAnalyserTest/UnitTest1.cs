using MoodAnalyserProblem;
namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in sad mood";
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
            string res = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("SAD", res);
        }
        [Test]
        public void GivenAnyMood_WhenAnalyze_ShouldReturnHappy()
        {
            string message = "I am in good mood";
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
            string res = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("HAPPY", res);
        }
    }
}