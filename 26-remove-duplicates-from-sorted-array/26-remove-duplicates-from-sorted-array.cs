public class Solution {
    public int RemoveDuplicates(int[] nums) {
       
        int len = nums.Length;
        
        int i =0;
        int j = 1;
        
        while( j < len)
        {
            if(nums[i] == nums[j])
            {
                j++;
            }
            else
            {
                i++;
                nums[i] = nums[j];
            } 
        }
        return i + 1;
    }
}