namespace c_LeetCode.Easy.Array;

public class FindNumberWithEvenNumber
{
    private static bool EvenDigit(int n)
    {
        var digits = 0;
        while (n > 0)
        {
            digits++;

            n /= 10;
        }

        return digits % 2 == 0;
    }

    public int FindNums(int[] num)
    {
        return num.Count(EvenDigit);
    }

    public static void Main1(string[] args)
    {
        Console.WriteLine(" nhap so luong phan tu trong mang ");
        var n = int.Parse(Console.ReadLine());
        var nums = new int[n];
        Console.WriteLine("nhap cac phan tuw ( cacsh nhau moiwr dau cach    ");
        string[] input = Console.ReadLine().Split(' ');
        for (var i = 0; i < input.Length; i++) nums[i] = int.Parse(input[i]);

        var find = new FindNumberWithEvenNumber();

        var result = find.FindNums(nums);

        Console.WriteLine($"Số lượng số có số chữ số chẵn: {result}");
    }
}