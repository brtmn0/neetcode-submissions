public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> check = new HashSet<int>(nums.Length);
        for(int i = 0; i < nums.Length; i++) {
            if (!check.Add(nums[i])) {
                return true;
            }
            
        }
        return false;
    }
}