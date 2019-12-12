using System;

namespace BinaryGuess
{
  class Program
  {
    static void Main(string[] args)
    {
      var gamePlay = true;
      var min = 0;
      var max = 100;
      var initializer = max / 2;

      int guesses = 0;

      string gameStart;
      string secretNum;
      string userReady;


      Console.WriteLine("\nDo you want you mind read? Type P to Play\n");
      gameStart = Console.ReadLine();
      gameStart = gameStart.ToUpper();

      if (gameStart == "P")
      {

        Console.WriteLine($"\nPick a number {min} - {max} and I will read your mind \n\nType R when Ready\n");
        userReady = Console.ReadLine();
        userReady = userReady.ToUpper();

        if (userReady == "R")
        {

          while (gamePlay == true)

          {
            Console.WriteLine($"\nIs your number {initializer}?\n\nType H for Higher or L for Lower\n\nWhen your mind is read type W\n");

            secretNum = Console.ReadLine();
            secretNum = secretNum.ToUpper();

            if (secretNum == "H")
            {
              min = initializer;
              initializer = (min + max) / 2;
              guesses++;
            }
            else if (secretNum == "L")
            {
              max = initializer;
              initializer = (min + max) / 2;
              guesses++;
            }
            else if (secretNum == "W")
            {
              gamePlay = false;
              Console.WriteLine($"\nNow it all makes sense\n\nI only used {guesses} hints\n");
            }
            else
            {
              Console.WriteLine("\nInvalid entry\n\nYour Loss\n");
              gamePlay = false;
            }
          }

        }

        else
        {
          Console.WriteLine("Your Loss");
        }

      }
      else
      {
        Console.WriteLine("Your Loss");
      }


    }
  }
}

// i would like to figure out how to make 50 dynamic instead
// block user from continuing to guess
