using System;
using System.Threading;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            int i = 0;
            Console.WriteLine("Welcome to The Game!");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Press X to Start");
            string key = Console.ReadLine();
            if (key == "X" || key == "x")
            {
                Load();
                Console.Clear();
                Console.WriteLine("What is your name?");
                String username = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Hello " + username + "!");
                Thread.Sleep(500);
                Console.Clear();
                Thread.Sleep(1000);
                //Console.WriteLine(""); need to find ideas for what to start my game.
            }
        }

        public static void Load()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                string load1 = "initializing...";
                Console.WriteLine(load1);
                Thread.Sleep(400);
                Console.Clear();
                string new_load2 = load1.Replace("initializing...", "initializing..");
                Console.WriteLine(new_load2);
                Thread.Sleep(400);
                Console.Clear();
                string new_load3 = new_load2.Replace("initializing..", "initializing.");
                Console.WriteLine(new_load3);
                Thread.Sleep(400);
                Console.Clear();
                string new_load4 = new_load3.Replace("initializing.", "initializing");
                Console.WriteLine(new_load4);
                Thread.Sleep(400);
            }
        }
    }
}