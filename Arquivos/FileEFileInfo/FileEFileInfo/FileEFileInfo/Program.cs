using System;

using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\gabri\Documents\Programacao\file1.txt";

            string targetPath = @"C:\Users\gabri\Documents\Programacao\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ocerreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}