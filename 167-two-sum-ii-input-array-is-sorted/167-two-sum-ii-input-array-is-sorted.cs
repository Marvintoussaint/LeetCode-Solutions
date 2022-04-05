public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        // define pointer
        int L = 0, len = numbers.Length, R = len - 1;
        
        // two pointers
        while(L < R)
        {
            int sum = numbers[L] + numbers[R];
            if(sum == target)
            {
                return new int [] {L + 1, R + 1};
            }else if(sum < target)
            {
                L++;
            }else{
                R--;
            }
        }
        return new int [] {-1,-1};
    }
}