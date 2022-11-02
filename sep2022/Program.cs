using System;

namespace sep2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ValidAnagram242 t02 = new ValidAnagram242();
            bool result = t02.IsAnagram("anagram", "nagaram");

            RotatingString796 t03 = new RotatingString796();
            t03.RotateString("abcde", "cdeab");
        }
    }
}
