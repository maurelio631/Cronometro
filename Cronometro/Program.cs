using System;

namespace Cronometro
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
            Console.WriteLine("Seja bem-vindo ao seu cronômetro!");
            Console.WriteLine("");
            Console.WriteLine("Selecione a opção desejada");
            Console.WriteLine("");
            Console.WriteLine("S - Segundos - 10s = 10 segundos");
            Console.WriteLine("M - Minutos - 1m = 1 minuto");
            Console.WriteLine("E - Sair ");

            string opcao = Console.ReadLine().ToLower();
            char medida = char.Parse(opcao.Substring(opcao.Length - 1, 1)); //Pegar o ultimo caractere da string
            int tempo = int.Parse(opcao.Substring(0, opcao.Length - 1));//Pegar o tempo inserido
            int multiplicador = 1;

            if (medida == 'm')
                multiplicador = 60;

            if (tempo == 0)
                System.Environment.Exit(0);

            Start(tempo * multiplicador);

        }

        static void Start(int time)
        {

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro Finalizado");
            Thread.Sleep(2000);
            Menu();
        }
    }
}