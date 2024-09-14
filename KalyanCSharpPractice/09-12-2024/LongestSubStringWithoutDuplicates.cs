using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_12_2024
{
    public class LongestSubStringWithoutDuplicates
    {
        public static int LengthOfString(string s)
        {
            HashSet<char> hset = new HashSet<char>();

            int l = 0;
            int res = 0;


            for (int r = 0; r < s.Length; r++)
            {
                while (hset.Contains(s[r]))
                {
                    hset.Remove(s[r]);
                    l++;
                }

                hset.Add(s[r]);

                res = Math.Max(res, (r - l + 1));
            }

            return res;
        }

        public static void Main(string[] args)
        {
            var s = "xxxx";

           var length =  LengthOfString(s);

           Console.WriteLine("Max Length sub string without duplicates is : " + length);

        }

    }
}
