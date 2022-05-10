public class Solution {
    public void DuplicateZeros(int[] arr) {
        int i =0;
        
        int len = arr.Length;
        
        while (i < len)
        {
            if(arr[i] == 0)
            {
                // shift
                
                for(int j = len -1 ; j > i; j--)
                {
                    arr[j] = arr[j-1];
                }
                
                // duplicate 
               if(i + 1 < len)
               {
                   arr[i+1] = 0;
               }
                i++;
            }
            i++;
        }
    }
}