using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }


        public static string Add(int a, int b, bool c)
        {
            int sum = a + b;            
            if (c == true && sum == 1)
            {
                return ($"{sum} dollar"); 
            }
            else if (c == true && sum > 1)
            {
                return ($"{sum} dollars");
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
