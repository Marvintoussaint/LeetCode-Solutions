public class Solution {
    public void MoveZeroes(int[] nums) {
        
        // base case
        
        int len = nums.Length;
        
        if( len < 2)
        {
            return;
        }
        
        // define pointers
        int left = 0;
        int right = 1;
        
        while ( right < len)
        {
            if (nums[left] != 0)
            {
                left++;
                right++;
            }else if(nums[right] == 0)
            {
                right++;
            }else{
                int temp = nums[right];
                nums[right] = nums[left];
                nums[left] = temp;
            }
        }
    }
}