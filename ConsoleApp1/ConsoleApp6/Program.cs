//----------------------------------------------------------------------------------------------------------//
// Vale ressaltar que quando este código foi testado no Visual Studio 2022 Community,                       //
// ao criar o novo diretorio "newfolder" dentro do diretorio principal "myfolder",                          //
// ao rodar a primeira vez ele primeiramente vai rodar e verificar todos os arquivos e diretorios           //
// presentes no diretorio principal, e após isso é que é realmente criado o novo diretorio dentro dele,     //
// então para verificar o diretorio basta rodar novamente o código, ou criar o diretorio antes.             //
//----------------------------------------------------------------------------------------------------------//

using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp6\myfolder";
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // Diretorios do diretorio "path".
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders) // Printar todos os diretorios dentro do diretorio raiz "path".
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // Arquivos do diretorio "path".
                Console.WriteLine("FILES:");
                foreach (string s in files) // Printar todos os arquivos dentro do diretorio raiz "path".
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(@"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp6\myfolder\newfolder"); // Criação do novo diretorio.
            }
            catch (IOException e) // Caso ocorra um erro.
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}