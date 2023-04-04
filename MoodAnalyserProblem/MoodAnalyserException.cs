using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    internal class MoodAnalyserException : Exception 
    {
        public enum Exceptiontype
        {
            NULL_MOOD,EMPTY_MOOD
        }
        public Exceptiontype ExceptionType;
        
        public MoodAnalyserException(Exceptiontype exceptiontype, string message) : base(message)
        {
            this.ExceptionType = exceptiontype;
        }
    }
}
