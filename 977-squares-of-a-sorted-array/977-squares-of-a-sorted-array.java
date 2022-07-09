class Solution {
    public int[] sortedSquares(int[] nums) {
                int left = 0;

        int right = nums.length -1;

        int [] result = new int [nums.length];

        int current = right;

        while(left <= right)
        {
            if (Math.abs(nums[left]) > Math.abs(nums[right])) {
                result[current -- ] = nums[left] * nums[left];
                left++;
            }else 
            {
                result[current -- ] = nums[right] * nums[right];
                right --;
            }
        }
        return result;
    }
}