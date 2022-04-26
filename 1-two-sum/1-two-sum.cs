public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
    int len = nums.Length;
        
        if(len < 2)
        {
            return null;
        }
    
        for(int i = 0; i < len -1 ; i++)
        {
            for(int j = i +1; j < len ; j++)
            {
                int sum = nums[i] + nums[j];
                
                if(sum == target)
                {
                    return new int [] {i,j};
                }
            }
        }
        return new int [] {-1,-1};
    }
}