namespace c_LeetCode.Easy.Arr
{
    public class ContainsDuplicate
    {
        public bool ContainsDuplicateimp(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            // Bước 2: Duyệt qua từng số trong mảng nums
            foreach (int num in nums)
            {
                if (result.Contains(num))
                {
                    return true;
                }

                result.Add(num);
            }

            return false;
        }
    }
}