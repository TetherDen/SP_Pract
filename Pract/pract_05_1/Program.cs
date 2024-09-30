namespace pract_05_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Создать метод для вывода чисел в заданном диапазоне. 
            ////Создать 3 таска, каждый передает метод свой диапазон и выполняются все вместе.

            //Task task1 = Task.Factory.StartNew(() => WriteNumbers(1,10));
            //Task task2 = Task.Factory.StartNew(() => WriteNumbers(50,100));
            //Task task3 = Task.Factory.StartNew(() => WriteNumbers(-10,0));

            //Task.WaitAll(task1,task2,task3);

            //===============================================

            ////Создайте приложение, использующее класс «Task». Приложение должно отображать текущее время и дату.Запустите задачу три способами:

            ////■ Через метод Start класса Task;
            //Task task1 = new Task(ShowDateTime);
            //task1.Start();

            ////■ Через метод Task.Factory.StartNew;
            //Task task2 = Task.Factory.StartNew(ShowDateTime);

            ////■ Через метод Task.Run.
            //Task task3 = Task.Run(ShowDateTime);

            //static void ShowDateTime()
            //{
            //    Console.WriteLine($"DateTime is {DateTime.Now}");
            //}
            //Task.WaitAll(task1, task2, task3);

            //===============================================

            //Создать метод для вывода чисел в заданном диапазоне. 
            //Создать 3 таска, каждый передает метод свой диапазон и выполняются все вместе.После выполнения задач, 
            //вывести сообщение о том, что метод Main завершил работу.

            //Task task1 = Task.Factory.StartNew(() => WriteNumbers(1, 10));
            //Task task2 = Task.Factory.StartNew(() => WriteNumbers(100, 110));
            //Task task3 = Task.Factory.StartNew(() => WriteNumbers(-10, 0));
            //Task.WaitAll(task1, task2, task3);

            //Console.WriteLine("End of main");

            //===============================================

            //Используя ParallelFor и отдельный метод, вывести на экран числа от 0 до 10.

            //Parallel.For(1,10, i => Method1(i));

            //Создать массива на 10 элементов, заполнить.Используя ParallelFor и лямбда выражение, вывести на экран элементы массива.
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Parallel.For(0, arr.Length, i => Method1(i));

            ////Используя ParallelForeach, передать группу чисел и подсчитать сумму цифр для каждого числа.

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;
            //Parallel.ForEach(arr, i =>
            //{
            //    sum += i;               
            //});
            //Console.WriteLine(sum);

            //===============================================

            //Создайте приложение, в котором:

            //1) Первый task выводит сумму чисел от 1 до 100;
            //2) Второй task записывает случайные 20 чисел в диапазоне от 1 до 100 в файл №1;
            //3) Третий task считывает числа из файла №1, преобразует в двоичную систему и записывает в файл №2.

            Random random = new Random();

            Task task1 = Task.Run(() =>
            {
                int sum = 0;
                int i = 1;
                while (i <= 100)
                {
                    sum += i;
                    i++;
                }
                Console.WriteLine(sum);
            });

            Task task2 = Task.Run(() =>
            {
                using (StreamWriter writer = new StreamWriter("task.txt"))
                {
                    for (int i = 0; i < 100; i++)
                    {
                        writer.WriteLine(random.Next(1,100));
                    }
                }
            });

            Console.ReadLine();





            static void Method1(int i)
            {
                Console.WriteLine(i);
            }
        }


        //static void WriteNumbers(int start, int end)
        //{
        //    for (int i = start; i < end; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
