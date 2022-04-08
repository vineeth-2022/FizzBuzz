using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        private Logger fileLogger = new Logger();
        public List<String> Multipleof_3_or_5(string n)
        {
            List<String> ans = new List<String>();
            int i = 0;
            try {
                fileLogger.Info("Multipleof_3_or_5 method Start");
                bool result = int.TryParse(n, out i);

            if (!result)
            {
                ans.Add("Invalid item");
                return ans;
            }
            int num = Convert.ToInt32(n);

            Boolean divisibleBy3 = (num % 3 == 0);
            Boolean divisibleBy5 = (num % 5 == 0);

            if (divisibleBy3 && divisibleBy5)
            {
                ans.Add("FizzBuzz");
            }
            else if (divisibleBy3)
            {
                ans.Add("Fizz");
            }
            else if (divisibleBy5)
            {
                ans.Add("Buzz");
            }
            else
            {
                ans.Add("Divided " + num.ToString() + " by 3");
                ans.Add("Divided " + num.ToString() + " by 5");
            }

            return ans;

        }
        catch(Exception ex)
            {
                fileLogger.Error("Error Occurred during Method Execution", ex);
            }
            return ans;
        }
    }
}
