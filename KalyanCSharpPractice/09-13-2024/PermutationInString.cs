using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_13_2024
{
    public class PermutationInString
    {
        public static bool CheckInclusion(string s1, string s2)
        {

            if (s1.Length > s2.Length) return false;

            int[] s1Count = new int[26];
            int[] s2Count = new int[26];

            // Initialize the count arrays with the first window in s2
            for (int i = 0; i < s1.Length; i++)
            {
                s1Count[s1[i] - 'a']++;
                s2Count[s2[i] - 'a']++;
            }

            // Function to check if two arrays are equal
            bool AreArraysEqual(int[] arr1, int[] arr2)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        return false;
                    }

                }

                return true;
            }

            // Slide the window over s2
            for (int i = 0; i < s2.Length - s1.Length; i++)
            {
                if (AreArraysEqual(s1Count, s2Count)) return true;
                s2Count[s2[i + s1.Length] - 'a']++;
                s2Count[s2[i] - 'a']--;
            }

            // check the last window
            return AreArraysEqual(s1Count, s2Count);

        }

        public static void Main(string[] args)
        {
           var res =  CheckInclusion("abc", "bcddbca");

           Console.WriteLine("result " + res);
        }
    }
}
