using System;
using System.Collections.Generic;

namespace may2022
{
    public class RansomeNote_338 {
        public static bool CanConstruct(string ransomNote, string magazine) {

            int lengthM = magazine.Length;
            //char[] arr = new char[lengthR];


            /*
            for(int i = 0; i < magazine.Length; i++) {
                for(int j = 0; j < ransomNote.Length; j++) {
                    if(magazine[i] == ransomNote[j] && arr[j] == '\0') {
                        arr[j] = ransomNote[j];
                        break;
                    }
                }
            }
            */

            /*
            for(int i = 0; i < lengthR; ) {
                for(int j = 0; j < lengthM; j++) {
                    if(ransomNote[i] == magazine[j]) {
                        magazine = magazine.Remove(j, 1);
                        ransomNote = ransomNote.Remove(i, 1);
                        lengthR--;
                        break;
                    } 
                }
            }
            */

            bool notFount = false;
            while(ransomNote != "") {
                for(int i = 0; i < lengthM; i++) {
                    notFount = true;
                    if(ransomNote[0] == magazine[i]) {
                        magazine = magazine.Remove(i, 1);
                        ransomNote = ransomNote.Remove(0, 1);
                        lengthM--;
                        notFount = false;
                        break;
                    }
                }
                if(notFount) {
                    break;
                }
            }

            /*
            string str = string.Empty;
            for(int i = 0; i < arr.Length; i++) {
                str += arr[i];
            }
            if(str == ransomNote) {
                return true;
            }
            */

            if(ransomNote == "") {
                return true;
            }

            return false;

            //bool answer = RansomeNote_338.CanConstruct("caa", "aabc");
        }
    }
}
