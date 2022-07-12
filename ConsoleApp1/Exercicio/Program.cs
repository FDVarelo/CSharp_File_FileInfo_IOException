//------------------------------------------------------------------//
// Fazer um programa para ler o caminho de um arquivo .csv          //
// contendo os dados de itens vendidos. Cada item possui um         //
// nome, preço unitário e quantidade, separados por vírgula. Você   //
// deve gerar um novo arquivo chamado "summary.csv", localizado     //
// em uma subpasta chamada "out" a partir da pasta original do      //
// arquivo de origem, contendo apenas o nome e o valor total para   //
// aquele item (preço unitário multiplicado pela quantidade),       //
// conforme exemplo.                                                //
//------------------------------------------------------------------//

//--------------------------------------------------------------------------//
// Exemplo:                                                                 //
//                                                                          //
// Source File:                             Output file (out/summary.csv):  //
// ==============================           =============================   //
// |TV LED,1290.99,1            |           |TV LED,1290.99             |   //
// |Video Game Chair,350.50,3   |           |Video Game Chair,1051.50   |   //
// |Iphone X,900.00,2           |           |Iphone X,1800.00           |   //
// |Samsung Galaxy 9,850.00,2   |           |Samsung Galaxy 9,1700.00   |   //
// ==============================           =============================   //
//--------------------------------------------------------------------------//

using System;
using System.IO;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path, example: C:\\temp\\CSharp_File_FileInfo_IOException\\ConsoleApp1\\Exercicio\\myfolder\\file.csv\n");
            string sourceFilePath = Console.ReadLine();

            // Se não quiser digitar pode comentar a linga de código 36, e descomentar a linha 41,
            // ou simplesmente copiar o que esta dentro das aspas duplas na linha 41, e colar quando pedir o path.

            //string sourceFilePath = @"C:\temp\CSharp_File_FileInfo_IOException\ConsoleApp1\Exercicio\myfolder\file.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath); // Le todas as linhas do path.

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); // Pega o nome do diretorio atual.
                string targetFolderPath = sourceFolderPath + @"\out"; // Adiciona um diretorio \out no diretorio atua.
                string targetFilePath = targetFolderPath + @"\summary.csv"; // Adiciona um arquivo summary.csv no diretorio \out.

                Directory.CreateDirectory(targetFolderPath); // Agora ele realmente cria o diretorio "out"

                using (StreamWriter sw = File.AppendText(targetFilePath)) // Escrever no arquivo summary.csv
                {
                    foreach (string line in lines) // Para cada linha em lines (arquivo file.csv).
                    {

                        string[] fields = line.Split(','); // Considerando que ',' (virgula), é o ponto em que separa as tabelas do .csv
                        string name = fields[0]; // Coluna 0 é o nome do produto.
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture); // Coluna 1 é o preço do produto.
                        int quantity = int.Parse(fields[2]); // Coluna 2 é a quantidade de produtos a serem comprados.

                        Product prod = new Product(name, price, quantity); // Chama a entidade Product, passando os parametros nome, preço e quantidade.

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture)); // Printa: <Name>,<prod.Total()> (Nome_do_Produto,Preço_Total).
                    }
                }
            }
            catch (IOException e) // Caso ocorra um erro.
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}