//using System;
using System.Text.RegularExpressions;

namespace ScrabbleScorer.Models
{
  public class ScrabbleScore
  {
    public string Input { get; set; }
    public int Score { get; set; }

    public ScrabbleScore(string input)
    {
      Input = input;
      Score = 0;
    }

    public bool IsValid()
    {
      if (Regex.IsMatch(Input, "^[a-zA-Z]*$"))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public char[] ToLowerArray()
    {
      char[] letterArray = Input.ToLower().ToCharArray();
      return letterArray;
    }

    public void ScoreCounter()
    {
      char[] LetterArray = ToLowerArray();
      foreach(char element in LetterArray)
      {
        if (Regex.IsMatch(char.ToString(element), "(a|e|i|o|u|l|n|r|s|t)"))
        {
          Score += 1;
        } 
        else if (Regex.IsMatch(char.ToString(element), "(d|g)"))
        {
          Score += 2;
        }
        else if (Regex.IsMatch(char.ToString(element), "(b|c|m|p)"))
        {
          Score += 3;
        }
        else if (Regex.IsMatch(char.ToString(element), "(f|h|v|w|y)"))
        {
          Score += 4;
        }
        else if (char.ToString(element) == "k")
        {
          Score += 5;
        }
        else if (Regex.IsMatch(char.ToString(element), "(j|x)"))
        {
          Score += 8;
        }
        else if (Regex.IsMatch(char.ToString(element), "(q|z)"))
        {
          Score += 10;
        }
      }
    }
  }
}