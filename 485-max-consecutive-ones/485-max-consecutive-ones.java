class Solution {
    public int findMaxConsecutiveOnes(int[] nums) {
        
                if (nums == null) {
            return -1;
        }

        // variables

        int len = nums.length;

        int max = Integer.MIN_VALUE;

        int counter = 0;


        for(int i = 0; i < len; i++)
        {
            if (nums[i] == 1) {
                counter++;
            }else
            {
                counter = 0;
            }
            max = Math.max(max, counter);
        }
        return max;

}
    
}