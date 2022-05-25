public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
 
        // Sort the array
        Array.Sort(nums);
 
        // Set the target value
        var target = 0;
 
        // Loop through numbers
        for (int index = 0; index < nums.Length; ++index) {
            // Skip duplicates
            if (index > 0 && nums[index] == nums[index - 1]) {
                continue;
            }
 
            // Find all 3 sum combinations that equal the target value
            var startIndex = index + 1;
            var endIndex = nums.Length - 1;
            while (startIndex < endIndex) {
                // Get the sum
                var sum = nums[index] + nums[startIndex] + nums[endIndex];
 
                // Sum equals target
                if (sum == target) {
                    // Add values to results when a target is found
                    var valueStart = nums[startIndex];
                    var valueEnd = nums[endIndex];
                    result.Add(new List<int>{nums[index], valueStart, valueEnd});
 
                    // Advance past duplicate items to the 'next' values
                    // at the start and end of the array
                    while (startIndex < endIndex && valueStart == nums[startIndex]) {
                        ++startIndex;
                    }
                    while (startIndex < endIndex && valueEnd == nums[endIndex]) {
                        --endIndex;
                    }
 
                // Sum is less than target
                } else if (sum < target) {
                    ++startIndex;
 
                // Sum is greater than target
                } else {
                    --endIndex;
                }
            }
        }
 
        return result;
    }
    }