namespace ScrabbleScorer.Models
{
  public class ScrabbleScore
  {
    public string Input { get; set; }

    public ScrabbleScore(string input)
    {
      Input = input;
    }
  }
}