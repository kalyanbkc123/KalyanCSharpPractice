using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._08_27_2024
{
    public class NumberOf1Bits
    {
        public int count(int value)
        {
            int count = 0;

            while (value != 0)
            {
                value = value & value - 1;
                count++;
            }

            return count;
        
        }
    }
}
