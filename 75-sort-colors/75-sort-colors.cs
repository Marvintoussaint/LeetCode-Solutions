public class Solution {
    public void SortColors(int[] nums) {
        
        int L = 0;
        
        int j = 0;
        
        int R = nums.Length -1;
        
        
        while( j <= R )
        {
            if(nums[j]==0)
            {
                swap(nums,L,j);
                L++;
                j++;
                
            }else if(nums[j] ==1)
            {
                j++;
            }else
            {
                swap(nums,R,j);
                R--;
            }
        } 
    }
    
    public void swap(int[]nums,int i,int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}