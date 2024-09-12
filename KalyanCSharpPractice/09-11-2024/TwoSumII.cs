using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_11_2024
{
    public class TwoSumII
    {

        public static int[] TwoSum(int[] numbers,int  target)
        {
            int l = 0, r = numbers.Length - 1;

            while(l < r)
            {
                int sum = numbers[l] + numbers[r];

                if(sum < target)
                {
                    l++;
                }
                else if(sum > target)
                {
                    r--;
                }
                else
                {
                    return new int[] { l + 1, r + 1 };
                }
            }

            return new int[0];

        }

        public static void Main(string[] args) {
            
            int[] numbers = { 1, 2, 3, 4};

            var res = TwoSum(numbers,3);

            foreach(var n in res)
            {
                Console.WriteLine(n);
            }

        }

    }
}
