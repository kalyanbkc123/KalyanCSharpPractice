using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._08_28_2024
{
   public class MissingNo
    {
            public int missingNumber(int[] nums)
            {

                int sum = 0;
                int res = 0;
                int n = nums.Length;

                for (int i = 0; i <= n; i++)
                {
                    sum ^= i;
                }
                for (int i = 0; i < n; i++)
                {

                    res ^= nums[i];
                }
                res = res ^ sum;
                return res;

            }
        


    }
}
