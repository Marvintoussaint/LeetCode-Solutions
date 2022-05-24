public class Solution {
    public int[] TwoSum(int[] arr, int target) {
    
            int [] ans = new int[2];
            int [] copy  = new int [arr.Length];
            arr.CopyTo(copy,0);
            Array.Sort(copy);

            int left = 0;
            int right =  arr.Length -1;

            while(left < right)
            {
                int sum = copy[left] + copy[right];

                if(sum == target)
                {
                    break;
                } else if (sum < target)
                {
                    left ++;
                }else{
                    right --;
                }
            }

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == copy[left] )
                {
                    ans[0] = i;
                }
            }

            for (var i = arr.Length -1; i >= 0; i--)
            {
                if (arr[i] == copy[right])
                {
                    ans[1] = i;
                }
            }

            return ans;
    }
}