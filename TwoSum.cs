// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

// Constraints:

// 2 <= nums.length <= 104
// -109 <= nums[i] <= 109
// -109 <= target <= 109
// Only one valid answer exists.

public int[] TwoSum(int[] nums, int target)
{
    int count = nums.Length, index = count - 1, value1 = 0, value2 = 1;

    while (count > 2)
    {
        var tempIndex = Array.IndexOf(nums, (target - nums[index]));

        if (tempIndex == -1 || tempIndex == index)
        {
            count--;
            index--;
            continue;
        }

        value1 = index;
        value2 = tempIndex;
        break;
    }

    return new int[] { value1, value2 };
}