using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_04_2024
{
    internal class ClimbingStairs
    {
            public int climbStairs(int n)
            {
                int a = 1;
                int b = 1;

                for (int i = 0; i < n - 1; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            }
        


    }
}
