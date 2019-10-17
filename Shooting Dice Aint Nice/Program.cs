using System;

namespace Shooting_Dice_Aint_Nice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            while (RollingDice())
            {
                Console.WriteLine("How many sides would you like your dice to have?");
                int numberSides,dice1,dice2;
                
                while (!int.TryParse(Console.ReadLine(), out numberSides))
                {
                    Console.WriteLine("That was invalid. Enter a number greater than Zero, Silly.");
                }
                 //create a way to validate that a valid inpur has been entered
                Random rand1 = new Random();
                dice1 = rand1.Next(1, numberSides + 1); 
                dice2 = rand1.Next(1, numberSides + 1);
                Console.WriteLine($"Your numbers are {dice1}, and {dice2}");
                if (dice1 ==  1 && dice2 == 1)
                {
                    dice1 = 1;
                    dice2 = 1;
                    Console.WriteLine("Congrats! Snake Eyes!");
                }
                else if (dice1 == 6 && dice1 == 6)
                {
                    dice2 = 6;
                    dice1 = 6;
                    Console.WriteLine("Congrats! Box Car!");

                }
            }

                   
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
