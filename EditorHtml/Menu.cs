using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            DrawBorder(30);
            DrawBox(12, 30);
            DrawBorder(30);
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("[1] Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("[2] Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("[0] Sair");
            Console.SetCursorPosition(3, 11);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

        public static void DrawBorder(int numberOfColumns)
        {
            Console.Write("+");
            for (var i = 0; i <= numberOfColumns; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawBox(int numberOfLines, int numberOfColumns)
        {
            for (var lines = 0; lines <= numberOfLines; lines++)
            {
                Console.Write("|");
                for (var i = 0; i <= numberOfColumns; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}