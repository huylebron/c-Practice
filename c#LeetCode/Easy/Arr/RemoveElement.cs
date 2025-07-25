namespace c_LeetCode.Easy.Arr;

public class RemoveElement
{
    public int RemoveElementimp(int[] nums, int val)
    {
        var i = 0;
        var j = nums.Length - 1;

        while (i < j)
            if (nums[i] != val)
            {
                i++;
            }
            else
            {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                j--;
            }

        return i;
    }
}