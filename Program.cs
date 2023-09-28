using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System.Data.SqlTypes;

namespace NumbersGame;

internal class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {

            // select a random number 
            Random random = new Random();
            int number = random.Next(1, 20);

            Console.WriteLine("välkommen! jag tänker på ett nummer. kan du gissa vilket? du får 5 försök");

            // loop for 5 rounds in the game 
            for (int i = 0; i < 5; i++)
            {
                //declaring users guess 
                int guessingNumber = int.Parse(Console.ReadLine());

                // bool to see if the method is true or false 
                bool correctGuess = CheckGuess(guessingNumber, number);
                
                if (correctGuess)
                {
                    break; // break out from the loop when correct number find 
                }
                else if (i == 4) // when round 5 is done and guess is incorrect it tells user
                {
                    Console.WriteLine("du klarade inte spelet på 5 försök");
                    break;
                }
            }
            // let the user deside if they want to start over 
            Console.WriteLine("vill du starta om spelet skriv in ja eller nej");
            string answer = Console.ReadLine();

            // loop so that you only kan white in "ja" or "nej" to start over or end game 
            while (answer != "ja" && answer != "nej")
            {
                Console.WriteLine("ojdå! något blev fel skriv in igen");
                answer = Console.ReadLine();
            }

            if (answer == "ja") // the game starts again 
            {
                playAgain = true;

            }
            else if (answer == "nej") // ends game
            {
                playAgain = false;
            }
 
        }
    }

    
    // bool method to check if the guessing is right 
    public static bool CheckGuess(int guessingNumber, int number)
    {
        if (guessingNumber < number)
        {
            Console.WriteLine("tyvärr du gissade för lågt");
        }
        else if (guessingNumber > number)
        {
            Console.WriteLine("tyvärr, du gissade för högt");
        }
        if (guessingNumber == number)
        {
            // generate a random number to shose fron the difrent answers
            Random random = new Random();
            int winner = random.Next(1, 5);

            // swtich case to get diffrent answers when you win the game 
            switch (winner)
            {
                case 1:
                    Console.WriteLine("Wohoo! du klarade det!");
                    break;
                case 2:
                    Console.WriteLine("Grattis! du klarade spelet");
                    break;
                case 3:
                    Console.WriteLine("grymt! du listade ut det hemliga nummret");
                    break;
                case 4:
                    Console.WriteLine("snyggt du kunde läsa mina tankar!");
                    break;
            }
            return true; // return true to main method if guesser winns the game 
        }
        return false; // retun false to main method if the guesser is not right 
    }

}