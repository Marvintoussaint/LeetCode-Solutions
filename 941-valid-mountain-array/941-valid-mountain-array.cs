public class Solution {
    public bool ValidMountainArray(int[] arr) {
        
int i = 0;   
        while(i < arr.Length && i +1 < arr.Length && arr[i] < arr[i + 1])     {
            i++;
        }
        
        if (i == 0 || i +1 >= arr.Length){
            return false;
        }
        
        while(i < arr.Length && i + 1 < arr.Length)
        {
            if(arr[i] <= arr[i++ +1]){
                return false;
            }
        }
        return true; 
    }
}