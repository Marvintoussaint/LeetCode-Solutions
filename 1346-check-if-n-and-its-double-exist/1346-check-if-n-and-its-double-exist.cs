public class Solution {
    public bool CheckIfExist(int[] arr) {
        int len = arr.Length;
        
        for ( int i = 0; i < len; i++)
        {
            for (int j = i + 1 ; j < len ; j++)
            {
                if(arr[i] == arr[j] * 2 || arr[i] * 2 == arr[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}