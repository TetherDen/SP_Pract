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

        //public class User
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public User(string name, int id)
        //    {
        //        Name = name;
        //        Id = id;
        //    }
        //}

        //==================================================================



        static async Task Main(string[] args)
        {

            ////Создать задачу на асинхронный вывод из цикла элементов массива.Через 5 секунд, отменить операцию.
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //await PrintArrAsync(arr);

            //==================================================================

            //Создать асинхронный метод, передать туда массив класса и имя для поиска человека.
            //    При нахождении человека, отменить операцию и вернуть человека, вывести его на экран.

            //List<User> users = new List<User> { new ("Joe",10), new ("John",11), new User("Jimmy",14), new("Jimbo",15)  };
            //User user = await FindName(users, "Jimbo");
            //Console.WriteLine(user.Name,user.Id);

            //static async Task<User> FindName (List<User> list, string name)
            //{
            //    foreach (var user in list)
            //    {
            //        await Task.Delay(100);
            //        if (user.Name == name)
            //            return user;
            //    }
            //    return null;
            //}


            //==================================================================


            //Используя класс DirectoryInfo, получить имена файлов и подкаталоги из папки, адрес к которой, введет пользователь.

            //string path = "C:\\Users\\admin\\source\\repos\\System_Programming\\Practice\\Pract\\Pract_07\\Pract_07";

            //DirectoryInfo dir = new DirectoryInfo(path);


            //FileInfo[] files = dir.GetFiles();
            
            //foreach (FileInfo file in files)
            //{
            //    Console.WriteLine($"Имя файла:  " + file.Name);

            //}
            //DirectoryInfo[] directories = dir.GetDirectories();
            //foreach (DirectoryInfo directory in directories)
            //{
            //    Console.WriteLine(directory.Name);
            //}

            //==================================================================

            //Создать программу, переписывающую в текстовый файл g содержимое файла f, 
            //исключая пустые строки, а остальные дополнить справа пробелами или ограничить до n символов.

            string pathIn = "C:\\Users\\admin\\source\\repos\\System_Programming\\Lesson_07_02\\Lorem.txt";
            string pathOut = "C:\\Users\\admin\\source\\repos\\System_Programming\\Lesson_07_02\\NewFileG.txt"; ;
            List<string> result = new();

            using (StreamReader sr = new StreamReader(pathIn))
            {
                string line;
                while (sr.Peek() != -1)
                {
                    line = sr.ReadLine();
                    if (line != null && line.Length > 0 && line != " ")
                    {
                        line += " ";
                        result.Add(line);
                    }
                }

            }

            using (StreamWriter sw = new StreamWriter(pathOut))
            {
                foreach (string line in result)
                {
                    sw.WriteLine(line);
                }
            }
            //foreach (string line in result)
            //{
            //    Console.WriteLine(line);
            //}




            //DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Leonid\Desktop\Heroes Assets]backgrund");  // тут надо путь
            //FileInfo[] files = dir.GetFiles("*.jpg", SearchOption.AllDirectories);
            //Console.WriteLine($"Найдено {files.Length} файлов");
            //foreach (FileInfo file in files)
            //{
            //    Console.WriteLine("\n************\n");
            //    Console.WriteLine($"Имя файла:  " + file.Name);
            //    Console.WriteLine($"Размер файла: " + file.Length);
            //    Console.WriteLine($"Время создание файла: " + file.CreationTime);
            //}



        }
    }
}
