using System;

namespace BinaryGuess
{
  class Program
  {
    static void Main(string[] args)
    {
      var gamePlay = true;
      var min = 0;
      var max = 500000;
      var initializer = (max) / 2;

      int guesses = 0;
      int lastGuess = 0;

      string gameStart;
      string secretNum;
      string userReady;


      Console.WriteLine("Do you want you mind read? Type P to Play");
      gameStart = Console.ReadLine().ToUpper();

      while (gameStart != "P")
      {
        Console.WriteLine("Error: Do you want you mind read? Type P to Play");
        gameStart = Console.ReadLine().ToUpper();
      }
      if (gameStart == "P")
      {
        Console.WriteLine($"\nPick a number {min} - {max } and I will read your mind \n\nType R when Ready\n");
        userReady = Console.ReadLine().ToUpper();
        while (userReady != "R")
        {
          Console.WriteLine($"\nPick a number {min} - {max } and I will read your mind \n\nType R when Ready\n");
          userReady = Console.ReadLine().ToUpper();
        }

        if (userReady == "R")
        {

          while (gamePlay == true)

          {
            Console.WriteLine($"\nIs your number {initializer}?\n\nType H for Higher or L for Lower\n\nWhen your mind is read type W\n");

            secretNum = Console.ReadLine().ToUpper();

            if (secretNum == "H")
            {
              if (initializer == max)
              {
                Console.WriteLine("\nCHEATER\n");
                gamePlay = false;
              }
              else if (lastGuess != initializer)
              {
                min = initializer;
                lastGuess = initializer;
                initializer = (int)Math.Round((min + max) / 2d);
                guesses++;
              }
            }
            else if (secretNum == "L")
            {
              if (initializer == min)
              {
                Console.WriteLine("\nCHEATER\n");
                gamePlay = false;

              }
              else if (lastGuess != initializer)
              {
                max = initializer;
                lastGuess = initializer;
                initializer = (int)Math.Round((min + max) / 2d);
                guesses++;
              }
            }
            else if (secretNum == "W")
            {
              Console.WriteLine($"\nNow it all makes sense\n\nI only used {guesses} hints\n");
              gamePlay = false;
            }
            else
            {
              Console.WriteLine("\nInvalid entry\n\nYour Loss\n");
              gamePlay = false;
            }
          }
          // Console.WriteLine("\nCHEATER\n");
        }

        else
        {
          Console.WriteLine("\nYour Loss\n");
        }

      }
      else
      {
        Console.WriteLine("\nYour Loss\n");
      }


    }
  }
}

// block user from continuing to guess
