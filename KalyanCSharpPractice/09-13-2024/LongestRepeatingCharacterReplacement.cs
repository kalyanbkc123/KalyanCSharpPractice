using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_13_2024
{
    public class LongestRepeatingCharacterReplacement
    {
        public static int CharacterReplacement(string s, int k)
        {
            int left = 0, maxFreqLetter = 0, maxLength = 0;

            int[] charCounts = new int[26];
               
            for (int r = 0; r < s.Length; r++)
            {
                charCounts[s[r] - 'A']++;

                maxFreqLetter = Math.Max(maxFreqLetter, charCounts[s[r] - 'A']);

                int lettersToChange = (r - left + 1) - maxFreqLetter;

                if (lettersToChange > k)
                {
                    charCounts[s[left] - 'A']--;
                    left++;

                }

                maxLength = Math.Max(maxLength, r - left + 1);
            }

            return maxLength;


        }


        public static void Main(string[] args)
        {
            var a = "XYYX";

            var length = CharacterReplacement(a, 2);

            Console.WriteLine(length);


        }
    }
}
