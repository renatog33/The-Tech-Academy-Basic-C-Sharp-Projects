using System;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess how many Super Bowls the SF 49ers have won?");//ask for input
            int number = Convert.ToInt32(Console.ReadLine());
            bool correct = number == 5;//the correct number is 5

            do //create a DO WHILE LOOP until they guess the correct number
            {
                switch (number) //use switch statement cases for the numbers that are too low
                {
                    case 0:
                        Console.WriteLine("You guessed 0. Too low.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You guessed 1. Too low.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. Too low.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Too low.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. That is correct!");
                        correct = true;
                        break;
                    default:
                        Console.WriteLine("That's too high.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!correct);

            Console.ReadLine();

            Console.WriteLine("Now, for all the marbles, how many Super Bowls have the Seattle Seahawks have won?");//ask for input
            int number1 = Convert.ToInt32(Console.ReadLine());
            bool correct1 = number1 == 1;//the correct number is 1.

            while (!correct1) //create a WHILE LOOP until they guess the correct number.  The flaw here is if they guess "1" as the first guess.  Therefore, the solution is to use the DO WHILE LOOP.
            {   
                switch (number1)
                {
                    case 0:
                    Console.WriteLine("You guessed 0. Too low. Try Again.");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    break;

                    case 1:
                    Console.WriteLine("You guessed 1. That is correct!");
                    correct1 = true;
                    break;

                    default:
                    Console.WriteLine("That's too high.Try Again.");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    break;

                }
               
            }
            Console.ReadLine();

        }
    }
}
