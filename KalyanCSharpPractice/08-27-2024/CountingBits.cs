using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._08_27_2024
{
    public class CountingBits
    {

        public int[] countBits(int n)
        {
            int[] dp = new int[n + 1];
            int offset = 1;

            for (int i = 1; i <= n; i++)
            {
                if (offset * 2 == i)
                { 
                offset = i;
                }
                dp[i] = 1 + dp[i - offset];

            }
            return dp;

        }
    }
}
