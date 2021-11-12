using System;
using System.Threading;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Seconds => 10s = 10 seconds");
            Console.WriteLine("M = Minutes => 1m = 1 minute");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();//Dado string
            char type = char.Parse(data.Substring(data.Length - 1, 1)); //Converte para char com Parse, conta quantidade de caracter digitado com Length, subtrai deixando apenas o ultimo caracter que é o tipo, m ou s

            int time = int.Parse(data.Substring(0, data.Length - 1)); //Converte para int com Parse, conta quantidade de caracter digitado com length, subtrai o ultimo caracter deixando apenas os primeiros que são os numeros
            int multiplier = 1;


            if (type == 'm')
                multiplier = 60;
            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //Timer de 1 sec.
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
