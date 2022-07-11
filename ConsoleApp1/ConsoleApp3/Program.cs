using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp3\texts\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(path, FileMode.Open); // Mesma coisa que: File.OpenRead(path);
                //sr = new StreamReader(fs);
                //string line = sr.ReadLine(); // Pega a primeira linha do file1.txt
                //Console.WriteLine(line); // Printa a linha.


                // ↓ Não é possível ler todas as linhas da mesma maneira do ConsoleApp1 e ConsoleApp2.
                /*string[] lines = File.ReadAllLines(path);
                foreach (string lineAll in lines)
                {
                    Console.WriteLine(lineAll);
                }*/

                // ↓ Para printar/ler todas as linhas é da seguinte maneira.
                sr = File.OpenText(path); // StreamReader (sr) vai abrir o arquivo file1.txt
                while (!sr.EndOfStream) // Enquanto sr não acabar.
                {
                    string line = sr.ReadLine(); // Pega a linha do file.txt
                    Console.WriteLine(line); // Printa a linha.
                }
            }
            catch (IOException e) // Caso ocorre um erro.
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Fecha o FileStream e StreamReader
                //if (sr != null) sr.Close();
                //if (fs != null) fs.Close();

                if (sr != null) sr.Close();
            }
        }
    }
}