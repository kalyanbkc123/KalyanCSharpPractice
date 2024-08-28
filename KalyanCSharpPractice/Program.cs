

using KalyanCSharpPractice._08_27_2024;

public class Program
{ 
    static void Main(string[] args) 
    {
        // Single Item (or) Number
        /*
        int[] nums = { 1, 1, 2, 2, 3, 3, 4 };

        SingleNumber sm = new SingleNumber();
        int res = sm.singleItem(nums);
        Console.WriteLine("The Single Number which is not duplicate is : "+res);
        */

        // Number of 1 Bits
        NumberOf1Bits num = new NumberOf1Bits();
        int res1 = num.count(7);
        Console.WriteLine("The Number of 1 Bits is : "+res1);




    }

}
