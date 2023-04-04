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
            try
            {
                if (string.IsNullOrEmpty(this.message))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.Exceptiontype.EMPTY_MOOD, "message is empty");
                }
                if (message.ToLower().Contains("sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch (Exception)
            {
                throw new MoodAnalyserException(MoodAnalyserException.Exceptiontype.NULL_MOOD, "message is null");
            }
        }
    }
}