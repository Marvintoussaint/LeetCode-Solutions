class Solution {
    public int findMaxConsecutiveOnes(int[] nums) {
     
        
        int max = Integer.MIN_VALUE;
        
        int counter = 0;
        
        for(int i = 0; i < nums.length; i++)
        {
            if(nums[i] == 1)
            {
                counter ++;
            }else
            {
                max = Math.max(max,counter);
                counter = 0;
            }
        }
                        max = Math.max(max,counter);
        return max;
    }
}