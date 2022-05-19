public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        
        int left = 0;
        
        int right = 1;
        
        int len = nums.Length;
        
        while(right < len)
        {
            if(nums[left] == nums[right])
            {
                right++;
            }else
            {
                left++;
                
                nums[left] = nums[right];
            }
            
        }
                    return left + 1;
    }
}