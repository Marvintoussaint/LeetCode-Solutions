class Solution {
    public void moveZeroes(int[] nums) {
         int len = nums.length;

        if (len == 0)
        {
            return;
        }

        int left_pointer = 0;
        int right_pointer = 1;

        while(right_pointer < len)
        {
            if (nums[left_pointer] != 0)
            {
                left_pointer++;
                right_pointer++;
            } else if (nums[right_pointer] == 0) {
                right_pointer++;
            }else {
                int temp = nums[right_pointer];
                nums[right_pointer] = nums[left_pointer];
                nums[left_pointer] = temp;
            }
        }
    }
    }
