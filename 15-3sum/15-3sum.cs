public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums);
      
        var result = new List<IList<int>>();
        
        var target = 0;
        
        int len = nums.Length; 
        
        for(int i = 0; i < len; i++ )
        {
            if(i > 0 && nums[i] == nums[i -1])
            {
                continue;
            }
            
            int L = i + 1;
            int R= len -1;
            
            while(L < R)
            {
                var sum = nums[i] + nums[L] + nums[R];
                
                if(sum == target)
                {
                    result.Add(new List<int> {nums[i],nums[L],nums[R]});
                    L++;
                    R--;
                    
                    while(L < R && nums[L] == nums[L-1])
                    {
                        L++;
                    }
                    
                    while (L < R && nums[R] == nums[R + 1])
                    {
                        R--;
                    }
                }else if (sum < target)
                {
                    L++;
                }else {
                    R--;
                }
                
            }
        }
        
            return result;
    }
    }