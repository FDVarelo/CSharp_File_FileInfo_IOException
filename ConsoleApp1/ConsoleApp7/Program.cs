using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp7\myfolder\file.txt"; // Pegar o caminho do arquivo.
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // Separador de diretorios, no caso: "\"
            Console.WriteLine("\nPathSeparator: " + Path.PathSeparator); // Separador de caminho, no caso: ";"
            Console.WriteLine("\nGetDirectoryName: " + Path.GetDirectoryName(path)); // Pega no nome do diretorio, no caso: "C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp7\myfolder"
            Console.WriteLine("\nGetFileName: " + Path.GetFileName(path)); // Pega o nome do arquivo, no caso: "file.txt"
            Console.WriteLine("\nGetExtension: " + Path.GetExtension(path)); // Pega a extenção do arquivo, no caso: ".txt"
            Console.WriteLine("\nGetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); // Nome do arquivo sem a extensão, no caso: "file"
            Console.WriteLine("\nGetFullPath: " + Path.GetFullPath(path)); // Pego o caminho completo até o arquivo, no caso: "C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\ConsoleApp7\myfolder\file.txt"
            Console.WriteLine("\nGetTempPath: " + Path.GetTempPath()); // Pega o caminho da pasta temp, no caso: "C:\Users\<your_user_name>\AppData\Local\Temp\"
        }
    }
}