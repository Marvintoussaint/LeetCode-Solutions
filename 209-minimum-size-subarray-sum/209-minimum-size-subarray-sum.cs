public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int len = nums.Length;
        int L = 0;
        int R = 0;
        
        int min = int.MaxValue;
        
        int sum = 0;
        
        while (R < len )
        {
            sum += nums[R];
            
            while( target <= sum)
            {
                min = Math.Min(min, R - L + 1);
                sum -= nums[L];
                L++;
            }
            
            R++;
        }
        
        return min == int.MaxValue ? 0 : min;
    }
}