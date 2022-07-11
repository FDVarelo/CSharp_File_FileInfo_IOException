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
            // Origem (criado anteriormente)
            string sourcePath = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp1\texts\file1.txt";
            // Destino, ao qual sera uma copia do destino (importante não criar um arquivo com o mesmo nome)
            string targetPath = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp1\texts\file2.txt";
        
            try
            {
                File.Copy(sourcePath, targetPath); // Copiar da origem para o destino.
                string[] lines = File.ReadAllLines(sourcePath); // Pega todas as linhas da origem.
                foreach (string line in lines) // Para cada linha, nas linhas da origem
                {
                    Console.WriteLine(line); // Mostrar na tela cada linha.
                }
            }
            catch (IOException e) // Caso ocorra um erro ex.: origem não existir, ou ja haver um destino com o mesmo nome.
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message); // Mensagem de Erro.
            }
        }
    }
}