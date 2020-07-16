//using System;
using System.Text.RegularExpressions;

namespace ScrabbleScorer.Models
{
  public class ScrabbleScore
  {
    public string Input { get; set; }

    public ScrabbleScore(string input)
    {
      Input = input;
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
  }
}