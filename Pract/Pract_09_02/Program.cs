using System.IO;
using System.Runtime.InteropServices;
namespace Pract_09_02
{
    internal class Program
    {
        [DllImport("Comdlg32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool GetOpenFileName([In, Out] OPENFILENAME ofn);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class OPENFILENAME
        {
            public int lStructSize = Marshal.SizeOf(typeof(OPENFILENAME));
            public IntPtr hwndOwner = IntPtr.Zero;
            public IntPtr hInstance = IntPtr.Zero;
            public string lpstrFilter = null;
            public string lpstrCustomFilter = null;
            public int nMaxCustFilter = 0;
            public int nFilterIndex = 0;
            public string lpstrFile = null;
            public int nMaxFile = 0;
            public string lpstrFileTitle = null;
            public int nMaxFileTitle = 0;
            public string lpstrInitialDir = null;
            public string lpstrTitle = null;
            public int Flags = 0;
            public short nFileOffset = 0;
            public short nFileExtension = 0;
            public string lpstrDefExt = null;
            public IntPtr lCustData = IntPtr.Zero;
            public IntPtr lpfnHook = IntPtr.Zero;
            public string lpTemplateName = null;
            public IntPtr pvReserved = IntPtr.Zero;
            public int dwReserved = 0;
            public int FlagsEx = 0;
        }
        static void Main(string[] args)
        {
            // Создайте приложение по типу «Console App», которое позволяет считать все текст из выбранного пользователем файла. 
            // Выбор файл происходит посредство вызова диалога, испльзуя хук.
            // Полученный текст, отобразите в консоли. Если в тексте присутствуют цифры, отобразите их общее количество.


            OPENFILENAME ofn = new OPENFILENAME();
            ofn.lpstrFilter = "Text Files (*.txt)\0*.txt\0All Files (*.*)\0*.*\0";
            ofn.nMaxFile = 260;
            ofn.lpstrFile = new string(new char[260]);
            ofn.lpstrFileTitle = new string(new char[260]);
            ofn.lpstrTitle = "Выберите файл";
            ofn.Flags = 0x00080000 | 0x00001000 | 0x00000800 | 0x00000200;

            List<string> fileContent = new();
            int digitsInFile = 0;
            if (GetOpenFileName(ofn))
            {
                Console.WriteLine("Выбран файл: " + ofn.lpstrFile);
                using(StreamReader sr= new StreamReader(ofn.lpstrFile))
                {
                    string line;
                    while (sr.Peek() != -1)
                    {
                        line = sr.ReadLine();
                        if (line != null && line.Length > 0 && line != " ")
                        {
                            line += " ";
                            fileContent.Add(line);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Операция отменена или произошла ошибка.");
            }

            foreach (string line in fileContent)
            {
                foreach (char ch in line)
                {
                    if (char.IsDigit(ch))
                    {
                        digitsInFile++;
                    }
                }
            }

            Console.WriteLine($"Digits in File: {digitsInFile}");
            foreach (string line in fileContent)
            {
                Console.WriteLine(line);
            } 

                
        }
    }
}
