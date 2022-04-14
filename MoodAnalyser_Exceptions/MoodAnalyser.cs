using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_Exceptions
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyserMood()
        {
            //try
            //{
            //    if (this.message.Contains("Sad"))
            //    {
            //        return "SAD";
            //    }
            //    else
            //    {
            //        return "HAPPY";
            //    }
            //}
            //catch
            //{
            //    return "HAPPY";

            //}
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Empty_Message, "Mood Should Not be Empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Null_Message, "Mood Should Not be Null");
            }

        }
    }
}
