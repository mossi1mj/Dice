using System;

namespace LAB6
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Intro();
            Console.Write("How many sides should each die have?");
            int num = int.Parse(Console.ReadLine());
            var random = new Random();
            for (int i = 1; i <= 2; i++)
            {
                int dice = random.Next(1, num);
                Console.WriteLine(dice);
            }

        }
        static void Intro()
        {
            bool continueLoop = true;
            while (continueLoop)
            {
                Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n):");
                Console.WriteLine("=========================================================");
                string answer = Console.ReadLine().ToLower();

                while (answer != "y" && answer != "n")
                {
                    Console.Write("Please enter either (y/n): ");
                    answer = Console.ReadLine().ToLower();
                }
                if (answer == "y")
                {
                    continueLoop = false;
                }
                else if (answer == "n")
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}
