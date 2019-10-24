using System;

namespace LAB6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resumeApp = Second("Welcome to the Grand Circus Casino! Roll the dice? (y/n):\n=========================================================");
            while (resumeApp)
            {
                Console.Write("How many sides should each die have? ");
                int num = int.Parse(Console.ReadLine());

                var rand = new Random();
                int diceOne = rand.Next(1, num);
                Console.WriteLine(diceOne);
                int diceTwo = rand.Next(1, num);
                Console.WriteLine(diceTwo);
                int sum = diceTwo + diceOne;

                if (diceOne == 1 && diceTwo == 1)
                {
                    Console.WriteLine("You rolled a Snake Eyes!");
                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    Console.WriteLine("Craps!");
                }
                else if (diceOne == 6 && diceTwo == 6)
                {
                    Console.WriteLine("Box Cars");
                }

                resumeApp = Second("Continue? (y/n)");
            }
        }
        public static bool Second(string title)
        {
            Console.WriteLine(title);
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
