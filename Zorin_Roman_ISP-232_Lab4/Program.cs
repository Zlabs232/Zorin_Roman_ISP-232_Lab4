using System.Runtime.CompilerServices;

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

            int g = 0;
            while (g < nums5.Length)
            {
                Console.WriteLine(nums5[g]);
                g++;
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

            int[] numbers = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45, -102, 76,
            -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];

            int l = numbers.Length;
            int h = l / 2; // Середина массива
            int temp;

            for (int i = 0; i < h; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[l - 1 - i];
                numbers[l - 1 - i] = temp;
            }

            foreach (int i in numbers)
            {
                Console.Write($"{i} \t");
            }

            int[] nums = [54, 7, -41, 2, 4, 2, 89, 33, -5, 12];
            int temper;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j]) 
                    {
                        temper = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temper;
                    }
                }
            }

            Console.WriteLine("\nМассив после сортировки: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            //List<string> people = new List<string>();
            //List<string> people = [];
            //List<string> people = new List<string>()
            //{ "Иван", "Игорь", "Аллександр"};

            List<string> people = ["Иван", "Игорь", "Аллександр"];
            var yourStudebt = new List<string>(people); //Пример инициализации коллекции элементами из другой коллекции 

            //List<string> people = new List<string>(10);
            //List<string> people = new(10);

            List<string> studetnt = ["Билли", "Игорь", "Степан"];
            string firstStudent = studetnt[0];
            Console.WriteLine(firstStudent);
            studetnt[0] = "Богдан";
            Console.WriteLine(studetnt[0]);

            Console.WriteLine(studetnt.Count);

            foreach(var std in studetnt)
                Console.WriteLine(std);

            studetnt.Add("Van");
            studetnt.AddRange(["Антон", "Денис"]);
            studetnt.Insert(1, "Кирилл");
            studetnt.InsertRange(1, ["Mike", "Kate"]);
            studetnt.Insert(7, "Михаил");
            studetnt.RemoveAt(1);
            studetnt.Remove("Михаил");
            studetnt.RemoveRange(1, 2);
            studetnt.Clear();

            //Task 1
            string[] weapons = { "sword", "shield", "potion", "sword", "potion", "potion" };

            //Task 2
            int[] points = [10, 20, 15, 30, 25];
            int sum = 0;
            for(int i = 0; i < points.Length; i++)
                sum += points[i];
            Console.WriteLine(sum);

            //Task 3
            int[] findMax = [1, 3, 7, 2, 5];
            int max = 0;
            for(int i = 0; i < findMax.Length; i++)
            {
                if(findMax[i] > max)
                    max = findMax[i];
            }
            Console.WriteLine(max);

            //Task 4
            int[] some = [1, 2, 3, 4, 5];
            int even = 0;
            int odd = 0;
            for (int i = 0; i < some.Length; i++)
                _ = some[i] % 2 == 0 ? even++ : odd++;

            Console.WriteLine($"Кол-во четных: {even}, Кол-во нечетных: {odd}");

            //Task 5
            int[] findMin = [120, 95, 110, 105, 100];
            int min = findMin[0];
            for (int i = 0; i < findMin.Length; i++)
            {
                if (findMin[i] < min)
                    min = findMin[i];
            }
            Console.WriteLine(min);

            //Task 6
            string[] resul = ["win", "loss", "win", "win", "loss"];
            int win = 0;
            int loss = 0;
            for(int i = 0; i<resul.Length; i++)
            {
                _ = resul[i] == "win" ? win++ : loss++;
            }
            Console.WriteLine($"Кол-во побед: {win}, Кол-во поражений: {loss}");

            //Task 7
            int[] findAvg = [15, 20, 25, 30, 10];
            int sum2 = 0;
            for(int i = 0; i < findAvg.Length; i++)
            {
                sum2 += findAvg[i];
            }
            Console.WriteLine($"Среднее кол-во очков: {(double)sum / findAvg.Length}");

            //Task 8 
            List<string> inventory = ["Меч", "Ласточка", "Бомба", "Зелье Гром", "Ласточка"];

            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] == "Ласточка")
                {
                    inventory[i] = "Кошка";
                }
            }

            Console.WriteLine("Инвентарь после замены:");
            foreach (var item in inventory)
            {
                Console.WriteLine(item);
            }

            //Task 9
            List<string> companions = ["Garrus", "Tali", "Mordin", "Grunt", "Jack"];
            List<string> roles = ["Лидер команды", "Техник", "Биотик", "Солдат", "Поддержка"];

            for (int i = 0; i < companions.Count && i < roles.Count; i++)
            {
                Console.WriteLine($"{roles[i]}: {companions[i]}");
            }
        }
    }
}
