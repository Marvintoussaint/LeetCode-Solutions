public class Solution {
    public int HeightChecker(int[] heights) {
        
            int len = heights.Length;
            int counter = 0;

            int[] expected = new int[len];

            for (int i = 0; i < heights.Length; i++)
            {
                expected[i] = heights[i];
             
            }

            Array.Sort(expected);

            for (int j = 0; j < expected.Length; j++)
            {
                if (expected[j] != heights[j])
                {
                    counter++;
                }
            }

            return counter;
        
        
        
    }
}