using System.Collections.Generic;

public class RotatingString796 {
    public bool RotateString(string s, string goal) {
        
        if(s.Length != goal.Length) {
            return false;
        }

        List<char> list = new List<char>();
        list.AddRange(s);

        for(int i = 0; i < s.Length; i++) {
            list.Add(list[0]);
            list.RemoveAt(0);

            string temp = new string(list.ToArray());
            if(temp == goal) {
                return true;
            }
        }



        // if(s.Length != goal.Length) {
        //     return false;
        // }

        // char[] arr = s.ToCharArray();
        // char tempChar;
        // for(int i = 0; i < s.Length; i++) {
        //     tempChar = arr[0];
        //     arr[0] = arr[arr.Length - 1];
        //     arr[arr.Length - 1] = tempChar;

        //     string temp = new string(arr);
        //     if(temp == goal) {
        //         return true;
        //     }
        // }

        return false;
    }
}