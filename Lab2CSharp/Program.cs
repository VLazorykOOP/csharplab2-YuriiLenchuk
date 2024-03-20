namespace Lab2CSharp
{
    internal class Program
    {
        static double avg(List<double> arr)
        {
            double avg = 0;
            foreach (double item in arr)
            {
                avg += item;
            }
            return avg/arr.Count;
        }
        static double avg(List<List<double>> arr)
        {
            double avg = 0;
            int count = 0;
            foreach (List<double> item in arr)
            {
                count += item.Count;
                foreach (double item1 in item)
                {
                    avg += item1;
                }
            }
            return avg / count;
        }

        static void task1()
        {
            List<double> arr = new List<double>() { 4.6, 5.9, 12, 51, 19, 11.2, 7, 2 };
            List<List<double>> arr2 = new List<List<double>>();
            arr2.Add(new List<double> { 1.1, 1.2, 1.3, 9,5, 2,7 });
            arr2.Add(new List<double> { 2.1, 2.2, 2.3, 5.2, 7.1 });
            arr2.Add(new List<double> { 3.1, 3.2, 3.3, 4.8, 2.4 });
            Console.WriteLine("Середнє першого масиву: " + avg(arr));
            Console.WriteLine("Середнє другого масиву: " + avg(arr2));
        }
        static void task2()
        {
            var random = new Random();   
            Console.WriteLine("Введіть розмір масиву: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0) n = 5;
            List<int> numbers = new List<int>(n);
            for(int i = 0; i < n; i++) numbers.Add(random.Next(101));

            int max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Array: ");
            foreach (var item in numbers) Console.Write(Convert.ToString(item) + ' ');
            Console.WriteLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != max)
                {
                    Console.WriteLine($"Номер елемента: {i}, Значення: {numbers[i]}");
                }
            }
        }
        static void task3()
        {
            int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, matrix.GetLength(1) - 1 - j];
                    matrix[i, matrix.GetLength(1) - 1 - j] = temp;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void task4()
        {
            Console.WriteLine("Масив:");
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введіть число: ");
            int threshold = Convert.ToInt32(Console.ReadLine());
            if (threshold == 0) threshold = 5;

            int[] counts = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > threshold)
                    {
                        count++;
                    }
                }
                counts[i] = count;
            }

            Console.WriteLine("Кількість елементів, більших за " + threshold + ", у кожному рядку:");
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine("Рядок " + (i + 1) + ": " + counts[i]);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 CSharp");
            Console.WriteLine("Task1: ");
            task1();
            Console.WriteLine("\nTask2: ");
            task2();
            Console.WriteLine("\nTask3: ");
            task3();
            Console.WriteLine("\nTask4: ");
            task4();
        }
    }
}
