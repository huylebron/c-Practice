namespace c_LeetCode.Easy.Arr
{
    public class RemoveElement
    {
        public int RemoveElementimp(int[] nums, int val)
        {
            int i = 0;
            int j = nums.Length - 1;

            while (i < j)
            {
                if (nums[i] != val)
                {
                    i++;
                }
                else
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    j--;
                }
            }

            return i;
        }
    }
}