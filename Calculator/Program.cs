using System;

namespace Calculator
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

            Console.WriteLine("Qual operação deseja executar?");
            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisão");
            Console.WriteLine("[5] Sair");

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Digite o número referente à operação desejada e tecle enter.");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Operacao(EOperacao.Soma); break;
                case 2: Operacao(EOperacao.Subtracao); break;
                case 3: Operacao(EOperacao.Multiplicacao); break;
                case 4: Operacao(EOperacao.Divisao); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Operacao(EOperacao operacao)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = 0;
            switch ((int)operacao)
            {
                case 1: resultado = Soma(v1, v2); break;
                case 2: resultado = Subtracao(v1, v2); break;
                case 3: resultado = Multiplicacao(v1, v2); break;
                case 4: resultado = Divisao(v1, v2); break;
                default: Console.WriteLine("Operação não econtrada!"); break;
            }

            Console.WriteLine($"O resultado da {operacao} é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static float Soma(float v1, float v2)
        {
            return v1 + v2;
        }

        static float Subtracao(float v1, float v2)
        {
            return v1 - v2;
        }

        static float Divisao(float v1, float v2)
        {
            return v1 / v2;
        }

        static float Multiplicacao(float v1, float v2)
        {
            return v1 * v2;
        }
    }

    enum EOperacao
    {
        Soma = 1,
        Subtracao = 2,
        Multiplicacao = 3,
        Divisao = 4
    }
}

