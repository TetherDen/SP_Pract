namespace pract_05_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать метод для вывода чисел в заданном диапазоне. 
            //Создать 3 таска, каждый передает метод свой диапазон и выполняются все вместе.

            Task task1 = Task.Factory.StartNew(() => WriteNumbers(1,10));
            Task task2 = Task.Factory.StartNew(() => WriteNumbers(50,100));
            Task task3 = Task.Factory.StartNew(() => WriteNumbers(-10,0));

            Task.WaitAll(task1,task2,task3);
        }

        static void  WriteNumbers (int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine (i);
            }
        }
    }
}
