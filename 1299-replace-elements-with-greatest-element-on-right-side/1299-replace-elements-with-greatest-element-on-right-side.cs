public class Solution {
    public int[] ReplaceElements(int[] arr) {
        
            var max = arr[arr.Length - 1];
            arr[arr.Length - 1] = -1;

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                var temp = arr[i];
                arr[i] = max;
                max = Math.Max(temp, max);
            }

            return arr;
    }
        
    }
