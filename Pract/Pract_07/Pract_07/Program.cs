namespace Pract_07
{
    internal class Program
    {
        static CancellationTokenSource cts = new CancellationTokenSource();
        static CancellationToken token = cts.Token;

        //static void PrintArr(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (token.IsCancellationRequested)
        //        {
        //            break;
        //        }
        //        Console.WriteLine(arr[i]);
        //        Thread.Sleep(1000);
        //    }
        //}

        //static async Task PrintArrAsync(int[] arr)
        //{
        //    cts.CancelAfter(3000);
        //    await Task.Run(()=> PrintArr(arr));
        //}

        //==================================================================

        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public User(string name, int id)
            {
                Name = name;
                Id = id;
            }
        }



        static async Task Main(string[] args)
        {

            ////Создать задачу на асинхронный вывод из цикла элементов массива.Через 5 секунд, отменить операцию.
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //await PrintArrAsync(arr);

            //==================================================================

            //Создать асинхронный метод, передать туда массив класса и имя для поиска человека.
            //    При нахождении человека, отменить операцию и вернуть человека, вывести его на экран.

            List<User> users = new List<User> { new ("Joe",10), new ("John",11), new User("Jimmy",14), new("Jimbo",15)  };
            User user = await FindName(users, "Jimbo");
            Console.WriteLine(user.Name,user.Id);

            static async Task<User> FindName (List<User> list, string name)
            {
                foreach (var user in list)
                {
                    await Task.Delay(100);
                    if (user.Name == name)
                        return user;
                }
                return null;
            }







        }
    }
}
