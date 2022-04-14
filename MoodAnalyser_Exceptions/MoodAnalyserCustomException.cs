using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_Exceptions
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            Null_Message, Empty_Message,
            No_Such_Field, No_Such_Method,
            No_Such_Class, Object_Creation_Issue
        }

        private readonly ExceptionType type;

        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
