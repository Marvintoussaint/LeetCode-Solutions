class Solution {
    public int longestOnes(int[] nums, int k) {
   
             int n = nums.length; 
        
        if(n < 2 && 0 < k) return n;
        
        int L = 0;
        
        int R = 0;
        
   
        
        int maxLength = Integer.MIN_VALUE;
        
        int counter = 0;
        
        while(R < n)
        {
            if(nums[R] == 0)
            {
                counter++;
            }
            
            while(counter > k)
            {
                if(nums[L] == 0)
                {
                    counter--;
                }
                
                L++;
            }
            
            maxLength = Math.max(maxLength, R - L + 1);
            
            R++;
        }
        return maxLength;
    }
}