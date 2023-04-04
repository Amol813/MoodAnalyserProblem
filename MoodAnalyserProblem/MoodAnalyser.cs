namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";
            return "HAPPY";
        }
    }
}