using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToSpeak.Util
{
    public class UnableSpeechException : Exception
    {
        public UnableSpeechException()
        {
        }

        public UnableSpeechException(string message) : base(message)
        {
        }

        public UnableSpeechException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
