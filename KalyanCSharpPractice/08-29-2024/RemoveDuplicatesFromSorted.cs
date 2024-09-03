using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._08_29_2024
{
     public class RemoveDuplicatesFromSorted
    {

        public static int removeDuplicate(int[] nums)
        {
            int i = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                }

                nums[i] = nums[j];
            }


            return i + 1;
        }

        static void main(string[] args)
        {

            int[] nums = { 1, 2, 3, 3, 4, 5, 6, };

            int res = removeDuplicate(nums);

            Console.WriteLine(res);


        }
    }
}
