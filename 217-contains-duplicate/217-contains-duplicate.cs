public class Solution {
    public bool ContainsDuplicate(int[] nums) {

   Dictionary<int,int> d = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(d.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                d[nums[i]] = 1;
            }
        }
        return false;
    }
}