using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public interface ILog
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
    public class Logger : ILog
    {
        public Logger()
        {
           //  Code written for initialization 
        }
        public void Info(string info)
        {
            //  Code written for info information into the ErrorLog text file
        }
        public void Debug(string info)
        {
            // Code written for Debug information into the ErrorLog text file
        }
        public void Error(string message, Exception ex)
        {
            // Code written for Error information into the ErrorLog text file
        }
    }
}
