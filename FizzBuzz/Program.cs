using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz objFizzBuzz = new FizzBuzz();
            List<string> result = objFizzBuzz.Multipleof_3_or_5("23");
        }
    }
}
