public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int L = 0;
        
        int R = 1;
        
        int counter = 0;
        
        while(R < nums.Length)
        {
            if(nums[L] != nums[R])
            {
                L++;
                nums[L] = nums[R];
                counter = 0;
            }else if (nums[L] == nums[R] && counter < 1)
            {
                counter++;
                nums[++L] = nums[R];
            }
            R++;
        }
        
        return L + 1;
    }
}