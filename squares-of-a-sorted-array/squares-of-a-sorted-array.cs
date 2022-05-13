public class Solution {
    public int[] SortedSquares(int[] nums) {
            
            
    int [] result = new int [nums.Length];
    int left =0;
    int right = nums.Length -1;
    for (var i = nums.Length -1; i>=0 ; i--)
    {
        if (Math.Abs(nums[left]) > nums[right])
        {
            result[i] = nums[left] * nums[left];
            left++;
        }
        else
        {
            result[i] = nums[right] * nums[right];
            right--;
        }
    }
    return result;
        
    }
}