public class Solution {
    public int HeightChecker(int[] heights) {
        int counter = 0;
        int len = heights.Length;
        
        int[] expected = new int[len];
        
        for(int i = 0; i < len ; i++)
        {
            expected[i] = heights[i];
        }
        
        Array.Sort(expected);
        
        
        
        for(int j = 0; j < expected.Length; j++)
        {
            if(expected[j] != heights[j])
            {
                counter++;
            }
        }
        
        return counter;
        
    }
}