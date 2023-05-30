using System;
using System.Globalization;
using System.Threading.Channels;
using System.Transactions;

int[] nums = { 1, 2, 3, 3, 3, 4, 5, 6, 8, 8, 10 };



Console.WriteLine("Original Length: " + $"{nums.Length}");

Solution solution = new Solution();
Console.WriteLine("Duplicates Removed Length: " + $"{solution.RemoveDuplicates(nums)}");
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1;
        if (nums.Length == 0)
        {
            k = 0;
            return k;
        }
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[i + 1])
            {
                nums[k++] = nums[i + 1];
            }
        }
        return k;
    }
}




