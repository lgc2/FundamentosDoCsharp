using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("[1] Abrir o arquivo");
            Console.WriteLine("[2] Criar novo arquivo");
            Console.WriteLine("[0] Sair");

            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto abaixo (ESC para sair do editor)");
            Console.WriteLine("---------------------------------------------------");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += System.Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            // Ao utilizar o `using` não precisamos no preocupar em abrir e fechar o aquivo manualmente
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadKey();
            Menu();
        }
    }
}