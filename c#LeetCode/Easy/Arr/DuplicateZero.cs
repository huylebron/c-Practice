public class DuplicateZero
{
    public void DuplicateZeros(int[] arr)
    {
        int n = arr.Length;

        int countZero = 0;
        foreach (int x in arr)
        {
            if (x == 0) countZero++;
        }

        int i = n - 1;
        int j = n + countZero - 1;

        while (i >= 0)
        {
            if (j < n)
            {
                arr[j] = arr[i];
            }

            if (arr[i] == 0)
            {
                j--;
                if (j < n)
                {
                    arr[j] = 0;
                }
            }
            i--;
            j--;
        }
    }
}