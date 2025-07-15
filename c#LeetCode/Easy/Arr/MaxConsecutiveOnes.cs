namespace c_LeetCode.Easy.Array;

public class MaxConsecutiveOnes
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var max = 0;
        var current = 0;

        foreach (var x in nums)
            if (x == 1)
            {
                current++;
                if (current > max) max = current;
            }
            else
            {
                current = 0;
            }

        return max;
    }
}