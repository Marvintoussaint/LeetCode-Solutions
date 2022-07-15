class Solution {
    public boolean isHappy(int number) {
                HashSet<Integer> seen = new HashSet<Integer>();
        
        while (number != 1) {
            
            int current = number;

            int sum = 0;

            while (current != 0) {
                int remainder = current % 10;
                sum = sum + (remainder * remainder);
                current = current / 10;
            }

            if (seen.contains(sum)) {
                return false;
            }

            number = sum;
            seen.add(sum);
        }
        return true;
        
    }
}