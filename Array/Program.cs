namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for(int i=0;  i<nums.Length; i++)
            {
                //new constran
                int[] node = { nums[i] %10 };
                Console.WriteLine(node[i]);
            }
        }
    }
}
