class Solution {
    public int findMaxConsecutiveOnes(int[] nums) {

                int n = nums.length ; 
        
        if(n == 0) return 0;
        
        
    int L = 0;
        
    int R = 0;
        
    int counter = 0;
        
    int maxLength = Integer.MIN_VALUE;
        

        
        
        while (R < n)
        {
            if(nums[R] == 1)
            {
                R++;
                counter++;
            }else
            {
                L = R;
                L++;
                R++;
                counter = 0;
            }
            
        maxLength = Math.max(maxLength, counter);
        }
        
        return maxLength;

}
    
}