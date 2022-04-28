public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int len = nums.Length;
        
        int left = 0;
        
        int right = 1;
        
        
        while (right < len)
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