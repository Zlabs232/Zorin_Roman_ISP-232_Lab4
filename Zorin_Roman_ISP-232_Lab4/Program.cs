namespace Lab4
{
    class Lab4
    {
        static void Main()
        {
            int[] empty_m; //Пустой массив
            int[] empty_m2 = new int[4];  //Присвоение значения массиву 

            int[] nums2 = new int[4] { 1, 2, 3, 5 };
            int[] nums3 = new int[] { 1, 2, 3, 5 };
            int[] nums4 = new[] { 1, 2, 3, 5 };
            int[] nums5 = { 1, 2, 3, 5 };
            int[] nums6 = [1, 2, 3, 5];

            Console.WriteLine(nums5[3]);
            var n = nums6[0];
            Console.WriteLine(n); //Пример индексация


        }
    }
}