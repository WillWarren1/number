using System;

namespace number
{
  class Program
  {
    static void Main(string[] args)
    {
      var stillGuessing = true;
      var counter = 1;
      var max = 100;
      var min = 1;
      var guess = (max + min) / 2;
      Console.WriteLine($"Is your number {guess},");
      while (stillGuessing)
      {
        // figure out the next guess
        // ask the user if the guess was correct

        Console.WriteLine("or is it higher or lower than my guess?");
        var input = Console.ReadLine();
        if (input == "yes")
        {
          stillGuessing = false;
        }
        else if (input == "higher")
        {
          counter++;
          min = guess + 1;
          guess = (max + min) / 2;
          Console.WriteLine($"Is your number {guess},");
        }
        else if (input == "lower")
        {
          counter++;
          max = guess - 1;
          guess = (max + min) / 2;
          Console.WriteLine($"Is your number {guess}?");
        }
      }
      Console.WriteLine($"Hey, I guess a total of {counter} times and your number was {guess}");
    }
  }
}
