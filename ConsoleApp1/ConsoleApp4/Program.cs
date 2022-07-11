using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp4\texts\file.txt";
            try
            {
                // Util pois não precisa fechar o arquivo.
                using (FileStream fs = new FileStream(path, FileMode.Open)) // Ao final o recurso sera automaticamente fechado.
                {
                    using (StreamReader sr = new StreamReader(fs)) // Pode colocar um using dentro de outro.
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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