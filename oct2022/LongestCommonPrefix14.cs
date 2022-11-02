public class LongestCommonPrefix14 {
    public string LongestCommonPrefix(string[] strs) {
        
        int length = strs[0].Length;;
        foreach(string str in strs) {
            if(str.Length < length) {
                length = str.Length;
            }
        }

        if(strs.Length == 1) {
            return strs[0];
        }

        if(length == 0) {
            return "";
        }


        string answer = "";
        for(int i = 0; i < length; i++) {

            char temp = strs[0][i];
            foreach(string str in strs) {
                if(str[i] != temp) {
                    return answer;
                }
            }
            answer += temp;
        }



        return "";
    }
}