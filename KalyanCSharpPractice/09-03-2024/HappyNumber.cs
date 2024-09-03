using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_03_2024
{
    internal class HappyNumber
    {
        public bool IsHappy(int n)
        {
            int slow = n, fast = SumSquareDigits(n);

            while (slow != fast)
            {
                fast = SumSquareDigits(fast);
                fast = SumSquareDigits(fast);
                slow = SumSquareDigits(slow);
            }

            return fast == 1;
        }

        private int SumSquareDigits(int n)
        {
            int output = 0;
            while (n != 0)
            {
                output += (n % 10) * (n % 10);
                n /= 10;
            }
            return output;
        }
    }
}
