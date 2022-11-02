using System;

public class PalindromeNumber09 {
    public bool IsPalindrome(int x) {
        
        if(x < 0) {
            return false;
        }

        if(x > 0 && x < 10) {
            return true;
        }

        char[] arr = x.ToString().ToCharArray();
        for(int i = 0; i < Math.Floor((decimal)(arr.Length / 2)) ; i++) {
            if(arr[i] != arr[arr.Length - i - 1]) {
                return false;
            }
        }

        return true;
    }
}