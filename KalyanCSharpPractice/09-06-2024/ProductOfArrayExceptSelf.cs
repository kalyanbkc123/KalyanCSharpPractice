using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_06_2024
{
    public class ProductOfArrayExceptSelf
    {

        public static int[] ProductArray(int[] numbers)
        {
            int prefix = 1, postfix =1 ;

            int[] res = new int[numbers.Length];


            for (int i = 0; i < numbers.Length; i++)
            {
                res[i] = prefix;
                prefix *= numbers[i];

            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                res[i] *= postfix;
                postfix *= numbers[i];

            }

            return res;
        }

        public static void Main(string[] args)
        {
            var arr = new int[]{ 1, 2, 3, 4 };

            var res = ProductArray(arr);

            foreach(var n in res)
            {
                Console.WriteLine(n);
            }
        }
    }
}
