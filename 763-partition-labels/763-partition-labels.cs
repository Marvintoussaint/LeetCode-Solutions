public class Solution {
    public IList<int> PartitionLabels(string s) {
      int[] last = new int[26];
            for (int i = 0; i < s.Length; i++)
                last[s[i] - 'a'] = i;

            int start = 0, lastMax = 0;
            var result = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                lastMax = Math.Max(lastMax, last[s[i] - 'a']);
                if (i == lastMax)
                {
                    result.Add(i - start + 1);
                    start = lastMax + 1;
                }
            }
            return result;
        }  
    }
