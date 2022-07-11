//---------------------------------------------//
// Deve ter sido criado anteriormente          //
// o arquivo de origem, no caso o file1.txt    //
// e também não pode haver um destino com      //
// o mesmo nome de outro arquivo ja existente, //
// por conta disso é bom sempre excluir o      //
// destino antes de rodar o código novamente.  //
//---------------------------------------------//

using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Origem.
            string sourcePath = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp2\texts\file1.txt";
            // Destino.
            string targetPath = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp2\texts\file2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // Instância o objeto.
                fileInfo.CopyTo(targetPath); // Copia a origem para o destino.
                string[] lines = File.ReadAllLines(sourcePath); // Pega todas as linhas da origem.
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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
