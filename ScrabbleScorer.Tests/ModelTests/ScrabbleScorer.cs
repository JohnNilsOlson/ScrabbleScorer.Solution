using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void ScrabbleScore_CreatesInstanceOfScrabbleScore_ScrabbleScore()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("scrabble");
      Assert.AreEqual(typeof(ScrabbleScore), newScrabbleScore.GetType());
    }
  }
}