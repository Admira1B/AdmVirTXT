using System;
using System.IO;

namespace txtcreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int start = 1;
            int end = 111;
            System.Console.WriteLine("Введите путь к деректории: ");
            string path = Console.ReadLine();
            System.Console.WriteLine("Введите кол-во файлов для создания: ");
            int repeatNum = int.Parse(Console.ReadLine());

            do
            {
                count++;
                string fileName = System.IO.Path.GetRandomFileName();
                fileName = System.IO.Path.ChangeExtension(fileName, ".txt");
                string pathLink = $@"{path}";
                string fullPath = $@"{path}/{fileName}";
                StreamWriter sw = new StreamWriter(fullPath);

                for (int i = start; i <= end; i++)
                {
                    sw.Write(i);
                }
                sw.Close();

                System.Console.WriteLine("Cоздан файл " + count);
                start *= 2;
                end *= 2;
            } while (count != repeatNum);
        }
    }
}