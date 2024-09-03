using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_03_2024
{
    internal class PlusOne1
    {
       
            public int[] PlusOne(int[] digits)
            {
                int one = 1;
                int i = 0;
                Array.Reverse(digits);

                while (one != 0)
                {
                    if (i < digits.Length)
                    {
                        if (digits[i] == 9)
                        {
                            digits[i] = 0;
                        }
                        else
                        {
                            digits[i]++;
                            one = 0;
                        }
                    }
                    else
                    {
                        Array.Resize(ref digits, digits.Length + 1);
                        digits[digits.Length - 1] = one;
                        one = 0;
                    }
                    i++;
                }
                Array.Reverse(digits);
                return digits;
            }
        }

    
}
