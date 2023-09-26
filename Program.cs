using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

namespace NumbersGame;

internal class Program
{
    static void Main(string[] args)
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
            bool correctGuess = checkguess(guessingNumber, number);

            // end the game if the metod is true
            if (correctGuess)
            {
                return;
            }
            else if (i == 4) // when round 5 is done and guess is incorrect it tells user and end game
            {
                Console.WriteLine("du klarade inte spelet på 5 försök");
                return; 
            }

        }

    }
    // bool method to check if the guessing is right 
    public static bool checkguess(int guessingNumber, int number)
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
            Console.WriteLine("Wohoo! du klarade det!");
            return true; // return true to main method if guesser winns the game 
        }
        return false; // retun false to main method if the guesser is not right 
    }

}