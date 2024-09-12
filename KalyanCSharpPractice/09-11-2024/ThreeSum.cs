using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_11_2024
{
    public class ThreeSum
    {
        public static IList<IList<int>> ThreeSumZero(int[] numbers)
        {
            IList<IList<int>> res = new List<IList<int>>();

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) break;

                if (i > 0 && numbers[i] == numbers[i - 1])
                {
                    continue;
                }

                int left = i + 1, right = numbers.Length - 1;

                while(left < right)
                {
                    int sum = numbers[i] + numbers[left] + numbers[right];

                    if(sum > 0)
                    {
                        right--;
                    }
                    else if(sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        res.Add(new List<int>() { numbers[i], numbers[left], numbers[right] });

                        left++;
                        right--;

                        while(left <right && numbers[left] == numbers[left-1])
                        {
                            left++;
                        }
                    }
                }

            }

            return res;

        }

        public static void Main(string[] args)
        {
            int[] numbers = new int[]{ -1,0,1,2,-1,-4};

            var res = ThreeSumZero(numbers);

            foreach(var res1 in res)
            {
                Console.Write("[");
                foreach(var res2 in res1)
                {
                    Console.Write(res2 + " ");
                }
                Console.WriteLine("]");
            }




        }

        
    }


}
