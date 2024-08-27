using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._08_27_2024
{
    public class SingleNumber
    {
        public int singleItem(int[] nums)
        {
            int res = 0;

            for(int i=0; i < nums.Length; i++)
            {
                res ^= nums[i];

            }

            return res;
        }
    }
}
