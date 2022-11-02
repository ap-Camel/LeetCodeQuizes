using System;

namespace oct2022
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeNumber09 PN = new PalindromeNumber09();
            bool PNtest = PN.IsPalindrome(10);

            LongestCommonPrefix14 LCP = new LongestCommonPrefix14();
            string[] strs = new string[] {"ab", "a"};
            string LCPtest = LCP.LongestCommonPrefix(strs);
        }
    }
}
