using System;
using System.IO;

namespace SintaxeBasicaParaLerArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path)) // abre o arquivo.
                {
                    while (!sr.EndOfStream) // enquanto não abrir o arquivo.
                    {
                        string line = sr.ReadLine(); //ler o que está no arquivo
                        Console.WriteLine(line); // imprimir o arquivo.
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
