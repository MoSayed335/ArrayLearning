namespace ArrayLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int[] nums = { 122, 222, 322, 422, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //    for (int i = 0; i < nums.Length; i++)
            //    {

            //        if (nums[i] % 4 == 0)
            //        {
            //        Console.WriteLine(nums[i]);
            //        }
            //        //else
            //        //    return ;
            //    }
            int[] numbers = { 4, 2, 8, 1 };

            //Array.Sort(numbers); // تصاعدي
            //Array.Reverse(numbers);// يعكس

            //Array.Clear(numbers, 0, numbers.Length);
            Array.Resize(ref numbers, 6);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
