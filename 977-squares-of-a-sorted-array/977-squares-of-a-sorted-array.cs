public class Solution {
    public int[] SortedSquares(int[] nums) {
        
            var left = 0;
            var right = nums.Length - 1;

            var result = new int[nums.Length];
            var current = right;

            while (left <= right)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    result[current--] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    result[current--] = nums[right] * nums[right];
                    right--;
                }
            }

            return result;
        }
    }