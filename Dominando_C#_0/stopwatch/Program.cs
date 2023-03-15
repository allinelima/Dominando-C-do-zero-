using System;
using System.Threading;

namespace StopWatch
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
            Console.WriteLine("S = seconds => 10s = 10 seconds");
            Console.WriteLine("M = minutes => 1m = 1 minute");
            Console.WriteLine("0 = exit");
            Console.WriteLine("How long do you want to count?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
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
            Console.WriteLine("let's go");
            Thread.Sleep(1000);
            Start(time);
        }

        static void Start(int time)
        {

            int currentTime = 0;
            Console.WriteLine();

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("finished stopwatch");
            Thread.Sleep(1000);
            Menu();
        }
    }
}