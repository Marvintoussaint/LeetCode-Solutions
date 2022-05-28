class Solution {
    public void moveZeroes(int[] nums) {
     
        int left = 0;
        
        int right = 1;
        
        int len = nums.length;
        
        while(right < len)
        {
            if(nums[left] != 0)
            {
                left++;
                right++;
            }else if(nums[right] == 0)
            {
                right++;
            }else 
            {
                int temp = nums[right];
                nums[right] = nums[left];
                nums[left] = temp;
            }
        }
        
    }
    }
