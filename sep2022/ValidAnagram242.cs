using System;
using System.Collections.Generic;

public class ValidAnagram242 {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length) {
            return false;
        }

        char[] arrS = s.ToCharArray();
        List<char> arrT = new List<char>();
        arrT.AddRange(t);

        for(int i = 0; i < arrS.Length; i++) {
            if(!arrT.Contains(arrS[i])) {
                return false;
            }

            arrT.Remove(arrS[i]);
        }

        if(arrT.Count == 0) {
            return true;
        }

        // char[] arrS = s.ToCharArray();

        // for(int i = 0; i < arrS.Length; i++) {
        //     if(true) {
        //         int index = t.IndexOf(arrS[i]);
        //         t = t.Remove(index, 1);
        //     }
        // }

        // if(t.Length == 0) {
        //     return true;
        // }

        // Console.WriteLine(t);

        return false;
    }
}