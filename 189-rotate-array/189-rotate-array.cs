public class Solution {
    public void Rotate(int[] nums, int k) {
        
        
    k = k % nums.Length;
    reverse(nums,0,nums.Length -1);
    reverse(nums,0,k-1);
    reverse(nums,k,nums.Length -1);
        
    }


    public void reverse(int[] nums, int start, int end)
    {
        while(start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}