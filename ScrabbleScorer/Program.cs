using System;
using ScrabbleScorer.Models;
public class Program
{
  public static void Main()
  {
    bool playAgain = true;
    while (playAgain)
    {
      Console.WriteLine("Enter the word you'd like to score");
      ScrabbleScore player = new ScrabbleScore(Console.ReadLine());
      if (player.IsValid() == false) 
      {
        Console.WriteLine("That input is not valid");
        Main();
      }
      else
      {
        player.ScoreCounter();
        Console.WriteLine($"The score for that word is {player.Score}");
        Console.WriteLine("Score another word? (Y/N)");
        if (Console.ReadLine() == "N")
        {
          playAgain = false;
          Console.WriteLine("Goodbye");
        }
      }
    }
  }
}