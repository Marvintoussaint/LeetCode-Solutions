public class Solution {
    public int RemoveDuplicates(int[] nums) {
    
        int len = nums.Length;
        
        if(len < 2)
        {
            return len;
        }
        
        // pointers
        
        int left = 0;
        int right = 1;
        
        while (right < len )
        {
            if(nums[left] == nums[right])
            {
               right ++; 
            }else if (nums[left] != nums[right])
            {
                left++;
                nums[left] = nums[right];
            }else
                right++;
        }
        return left + 1; 
    }
    
}