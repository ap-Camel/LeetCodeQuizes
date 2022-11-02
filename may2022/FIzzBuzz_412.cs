using System;
using System.Collections.Generic;

namespace may2022
{
    public class fizzBuzz_412{
        public static IList<string> FizzBuzz(int n) {

            List<string> list = new List<string>();

            for(int i = 1, f = 1, b = 1; i <= n; i++, f++, b++) {
                if(f == 3 && b == 5) {
                    list.Add("FizzBuzz");
                    f = b = 0;
                } else if(b == 5) {
                    list.Add("Buzz");
                    b = 0;
                } else if(f == 3) {
                    list.Add("Fizz");
                    f = 0;
                } else {
                    list.Add(i.ToString());
                }
            }

            return list;
        }
    }
}
