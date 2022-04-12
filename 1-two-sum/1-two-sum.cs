public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> hashtable = new Dictionary<int,int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(hashtable.ContainsKey(complement))
            {
                return new int[] {hashtable[complement],i};
            }else{
                hashtable[nums[i]] = i;
            }
        }
        throw new Exception("Not found");
}
    
}

