namespace Lab4
{
    class Lab4
    {
        static void Main()
        {
            int[] empty_m; //Пустой массив
            int[] empty_m2 = new int[4];  //Присвоение значения массиву 

            int[] nums5 = { 1, 2, 3, 5 };

            Console.WriteLine(nums5[3]);
            var n = nums5[0];
            Console.WriteLine(n); //Пример индексация

            nums5[1] = 505;
            Console.WriteLine(nums5[1]); // Замена элеммента 

            //int[] nums6 = [1, 2, 3, 5];
            // Console.WriteLine(nums5[6]); // Ошибка при обращении к несуществ. переменной
            
            Console.WriteLine(nums5.Length); //Длина массива

            Console.WriteLine(nums5[nums5.Length - 1]);
            Console.WriteLine(nums5[nums5.Length - 2]);
            Console.WriteLine(nums5[nums5.Length - 3]); //Пример выбора элементов с конца массива 

            Console.WriteLine(nums5[^1]);
            Console.WriteLine(nums5[^2]);
            Console.WriteLine(nums5[^3]); //Выбор элементов с конца

            foreach(int i in nums5)
            {
                Console.WriteLine(i);
            } //Перебор с помощью цикла foreach

            for(int i = 0; i < nums5.Length; i++)
            {
                Console.WriteLine(nums5[i]);
            }//Перебор с помощью цикла for

            for (int i = 0; i < nums5.Length; i++)
            {
                nums5[i] = nums5[i] * 2;
                Console.WriteLine(nums5[i]);
            }//Пример более лучшей гибкости цикла for по сравнению с foreach

            int j = 0;
            while (j < nums5.Length)
            {
                Console.WriteLine(nums5[j]);
                j++;
            }// Перебор массива с помощью while

            int[] nums1 = [0, 1, 2, 3, 4, 5];
            int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };//Пример многомерного массива

            object[] students = ["Иван", "Игорь", 4, 4.6, 'c']; //Более предпочтительный выбор
            dynamic[] students2 = ["Иван", "Игорь", 4, 4.6, 'c'];
            students2[4] = 4;
            Console.WriteLine(students[4].GetType());
            Console.WriteLine(students2[4].GetType());

            int[] numbs = [-1, -2, -3, 4, 5, -6, 0,
                 43, 56, -34, 12, 45, -102, 76, -45, 96,
                 -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
            int res = 0;
            foreach(int number in numbs)
            {
                if (number > 0)
                    res++;
            }
            Console.WriteLine($"Чисел больше нуля {res}");


        }
    }
}
