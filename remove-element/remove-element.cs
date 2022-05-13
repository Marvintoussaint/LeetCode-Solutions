public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
    if (nums.Length == 0)
    {
        System.Console.WriteLine("Array is empty");
    }
    int j=0;
    for (var i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[j] = nums[i];
            j++;
        }
    }
    return j;
    }
}