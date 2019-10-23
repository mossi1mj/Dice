using System;

namespace LAB6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resumeApp = Program.Second("Welcome to the Grand Circus Casino! Roll the dice? (y/n):\n=========================================================");
            while (resumeApp)
            {
                Console.Write("How many sides should each die have?");
                int num = int.Parse(Console.ReadLine());
                var random = new Random();
                int dice1 = random.Next(1, num);
                Console.WriteLine(dice1);
                int dice2 = random.Next(1, num);
                Console.WriteLine(dice2);
                int sum = dice2 + dice1;

                if (dice1 == 1 && dice2 == 1)
                {
                    Console.WriteLine("You rolled a Snake Eyes!");
                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    Console.WriteLine("Craps!");
                }
                else if (dice1 == 6 && dice2 == 6)
                {
                    Console.WriteLine("Box Cars");
                }

                resumeApp = Program.Second("Continue? (y/n)");
            }
        }
        static bool Second(string prompt)
        {
            Console.WriteLine(prompt);
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write("Please enter either (y/n): ");
                answer = Console.ReadLine().ToLower();
            }
            return answer == "y";
            
        }

    }
}
