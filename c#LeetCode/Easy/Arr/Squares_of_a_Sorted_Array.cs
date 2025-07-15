namespace c_LeetCode.Easy.Array;

public class Squares_of_a_Sorted_Array
{
    public int[] SortedSquares(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];

        var left = 0;
        var right = n - 1;

        var index = n - 1;

        while (left <= right)
        {
            var leftSq = nums[left] * nums[left];
            var rightSq = nums[right] * nums[right];

            if (leftSq > rightSq)
            {
                result[index] = leftSq;
                left++;
            }
            else
            {
                result[index] = rightSq;
                right--;
            }

            index--;
        }

        return result;
    }
}