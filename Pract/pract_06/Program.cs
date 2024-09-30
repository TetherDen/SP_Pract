using System.Numerics;

namespace pract_06
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Используя 2 метода, реализовать вывод названий методов, из методов 25 раз.
            //    Оба метода должны работать синхронно, с интервалом в 100 миллисекунд.

            //for (int i = 0; i < 25; i++)
            //{
            //    await Method1();
            //    await Method2();

            //}

            ////==================================================

            //Используя отдельный метод, посчитать до 100 и вернуть результат в метод Main, вывести его на экран.

            Console.WriteLine(await MyCalcAsync());

            ////==================================================

            // Выполните асинхронное умножение матриц. Вот так может выглядеть сигнатура метода, для этой операции:
            //static async Task<int[,]> MultiplyMatricesAsync(int[,] matrix1, int[,] matrix2)

            int[,] arr2d1 =
            {
                {1,2,3,},
                {4,5,6,},
                {7,8,9,},
            };
            int[,] arr2d2 =
            {
                {4,5,6,},
                {7,8,9,},
                {1,2,3,}
            };


        }

        static  async Task<int[,]> Multiply2D (int[,] arr, int[,] arr2)
        {
            for (int i = 0; i < arr2.GetLength (0); i++)
            {
                for (; i < arr2.GetLength (1); i++)
                {

                }
            }
        }



        ////==================================================
        static async Task<int> MyCalcAsync()

        {
            return await Task.Run(() => MyCalc());
        }

        static int MyCalc()
        {
            int n = 0;
            for (int i = 0; n < 100; n++)
            {
                n += 1;
            }
            return n;
        }
        //==================================================

        static async Task Method1()
        {
            Console.WriteLine("Method1()...");
            await Task.Delay(100);

        }
        static async Task Method2()
        {
            Console.WriteLine("Method2()...");
            await Task.Delay(100);
        }
    }
}
