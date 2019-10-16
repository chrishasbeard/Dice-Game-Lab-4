using System;

namespace Shooting_Dice_Aint_Nice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            while (RollingDice())
            {
                Console.WriteLine("How many sides would you like your dice to have?");
                string diceSides = Console.ReadLine();
                int numberSides = int.Parse(diceSides); //create a way to validate that a valid inpur has been entered
                Random rand1 = new Random();
                int dice1 = rand1.Next(1, numberSides + 1); // create method to generate the random numbers
                int dice2 = rand1.Next(1, numberSides + 1);
                Console.WriteLine($"Your numbers are {dice1}, and {dice2}");
            }

                    //create messages for if a boxcar or snake eyes has been generated
        } 
        public static bool RollingDice()
        {
            Console.WriteLine("Roll the dice?(y/n)");
            string userInput = Console.ReadLine().ToLower();
            switch(userInput)
            {
                case "y":
                    userInput = "y";
                        return true;
                case "n":
                    userInput = "n";
                    return false;
                default:
                    return RollingDice();
            }
        }
 
    }
}
