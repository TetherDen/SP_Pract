namespace Pract_07
{
    internal class Program
    {
        static CancellationTokenSource cts = new CancellationTokenSource();
        static CancellationToken token = cts.Token;

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                Console.WriteLine(arr[i]);
                Thread.Sleep(1000);
            }
        }

        static async Task PrintArrAsync(int[] arr)
        {
            cts.CancelAfter(3000);
            await Task.Run(()=> PrintArr(arr));
        }

        static async Task Main(string[] args)
        {

            //Создать задачу на асинхронный вывод из цикла элементов массива.Через 5 секунд, отменить операцию.
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            await PrintArrAsync(arr);
        }
    }
}
