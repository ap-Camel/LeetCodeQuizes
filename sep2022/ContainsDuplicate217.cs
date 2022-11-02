using System.Collections;
using System.Collections.Generic;

public class ContainsDuplicate217 {
    public bool ContainsDuplicate(int[] nums) {

        HashSet<int> temp = new HashSet<int>();
        int num = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(temp.TryGetValue(nums[i], out num )) {
                return true;
            } 

            temp.Add(nums[i]);
        }

        // Hashtable hash = new Hashtable();
        // for(int i = 0; i < nums.Length; i++) {
        //     if(hash.Contains(nums[i])) {
        //         return true;
        //     }
        //     hash.Add(nums[i], null);
        // }


        return false;
    }
}