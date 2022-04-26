public class Solution {
    public void DuplicateZeros(int[] arr) {
        
        var queue = new Queue<int>();
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == 0)
            {
                queue.Enqueue(0);
                queue.Enqueue(0);
            }else{
                queue.Enqueue(arr[i]);
            }
            
        int first = queue.Dequeue();
        arr[i] = first;
        }
                
    }
}