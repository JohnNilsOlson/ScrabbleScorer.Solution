using System;
using ScrabbleScorer.Models;
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter the word you'd like to score");
    string input = Console.ReadLine();
    ScrabbleScore player = new ScrabbleScore(input);
    if (player.IsValid() == false) 
    {
      Console.WriteLine("That input is not valid");
      Main();
    }
    else
    {
      player.ScoreCounter();
      Console.WriteLine($"The score for that word is {player.Score}");
    }
  }
}