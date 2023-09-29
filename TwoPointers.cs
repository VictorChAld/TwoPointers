using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class TwoPointers
    {
    public static int MaxArea(int[] nums)
    {
        //Two pointers
        if (nums.Length < 2)
        {
            return 0;
        }

        int maxValue = 0;
        int leftIndex = 0;
        int rightIndex = nums.Length - 1;

        while (leftIndex < rightIndex)
        {
            int currValue = 0;
            int leftValue = nums[leftIndex];
            int rightValue = nums[rightIndex];

            if (leftValue < rightValue)
            {
                currValue = leftValue * (rightIndex - leftIndex);
                leftIndex++;
            }
            else
            {
                currValue = rightValue * (rightIndex - leftIndex);
                rightIndex--;
            }

            maxValue = Math.Max(maxValue, currValue);
        }

        return maxValue;

    }
}
