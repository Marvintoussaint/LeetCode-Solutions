public class Solution {
    public int[] TwoSum(int[] arr, int target) {
    
              Dictionary<int,int> hm = new Dictionary<int,int>(arr.Length);

                for(int i = 0; i < arr.Length; i++)
                {
                    if (hm.ContainsKey(target- arr[i]))
                    {
                        return new int []  {hm[target - arr[i]],i};
                    }
                    hm[arr[i]] = i;
                }
                return new int [] {-1,-1};
        }
    }
