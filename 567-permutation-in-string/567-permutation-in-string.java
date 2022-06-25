class Solution {
    public boolean checkInclusion(String s1, String s2) {
        
        // define table
        int[] arr = new int[128];

        // define pointers

        int L = 0;

        int R = 0;

        // fill up the table

        char[] s1_arr = s1.toCharArray();
        char[] s2_arr = s2.toCharArray();

        for (char curr : s1_arr) {
            arr[curr]++;
        }

        // define counter

        int counter = 0;

        // define minimum length

        int minLength = Integer.MAX_VALUE;

        // while condition
        while (R < s2_arr.length) {

            char curr = s2_arr[R];

            if (--arr[curr] >= 0) {
                counter++;
            }

            // contract the window

            while (counter == s1.length()) {
                int curreLength = R - L + 1;

                minLength = Math.min(minLength, curreLength);

                char LeftChar = s2_arr[L];

                if (++arr[LeftChar] > 0) {
                    counter--;
                }

                L++;
            }

            R++;
        }
        return minLength == s1.length();
    }
}