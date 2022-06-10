public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        
        int maxLen = 0;
        
        int counter = 0;
        
        for( var i = 0; i < nums.Length ; i ++)
        {
            if(nums[i] == 0)
            {
                counter = 0;
            }else
            {
                counter++;
                maxLen = Math.Max(maxLen,counter);
            }
        }
            
        
        return maxLen;
    }
}