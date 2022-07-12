using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp5\texts\file.txt";
            string targetPath = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp5\texts\file_writed.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath); // Pegar todas as linhas.
                using (StreamWriter sw = File.AppendText(targetPath)) // Append em sw as linhas para o destino.
                {
                    foreach (string line in lines) // Rodar todas as linhas de origem.
                    {
                        sw.WriteLine(line.ToUpper()); // sw vai escrever/append a linha de sourcePath/origem em targetPath/destino em uppercase (maiusculo).
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}