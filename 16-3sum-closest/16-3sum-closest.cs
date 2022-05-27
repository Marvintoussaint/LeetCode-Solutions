public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
                var result = 0;
 
        // Keep track of the solution closest to the target
        var closestDifference = int.MaxValue;
 
        // Sort the array
        Array.Sort(nums);
 
        // Loop through numbers
        for (int index = 0; index < nums.Length; ++index) {
            // Skip duplicates
            if (index > 0 && nums[index] == nums[index - 1]) {
                continue;
            }
 
            // Find 3 sum combination closest to the target value
            var startIndex = index + 1;
            var endIndex = nums.Length - 1;
            while (startIndex < endIndex) {
                // Get the sum
                var sum = nums[index] + nums[startIndex] + nums[endIndex];
 
                // Determine how close the sum is to the target value
                var difference = Math.Abs(target - sum);
                if (difference < closestDifference) {
                    closestDifference = difference;
                    result = sum;
                }
 
                // An exact match is found, exit
                if (difference == 0) {
                    break;
 
                // Sum is less than target
                } else if (sum < target) {
                    ++startIndex;
 
                // Sum is greater than target
                } else {
                    --endIndex;
                }
            }
 
            // An exact match is found, exit
            if (closestDifference == 0) {
                break;
            }
        }
 
        return result;

            }
        }
    