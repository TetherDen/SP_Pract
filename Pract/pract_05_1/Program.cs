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

            Task task1 = Task.Factory.StartNew(() => WriteNumbers(1, 10));
            Task task2 = Task.Factory.StartNew(() => WriteNumbers(100, 110));
            Task task3 = Task.Factory.StartNew(() => WriteNumbers(-10, 0));
            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("End of main");
        }

        static void WriteNumbers(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
