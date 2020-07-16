using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    // ScrabbleScore newScrabbleScore;

    // [TestInitialize]
    // public void TestInitialize()
    // {
    //   ScrabbleScore newScrabbleScore = new ScrabbleScore("scrabble");
    // }

    [TestMethod]
    public void ScrabbleScore_CreatesInstanceOfScrabbleScore_ScrabbleScore()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("scrabble");
      Assert.AreEqual(typeof(ScrabbleScore), newScrabbleScore.GetType());
    }

    [TestMethod]
    public void IsValid_ChecksIfInputIsValid_True()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("SCRABBLE");
      Assert.AreEqual(true, newScrabbleScore.IsValid());
    }

    [TestMethod]
    public void IsValid_CheckIfInputIsInvalid_False()
    {
      ScrabbleScore badScrabbleScore = new ScrabbleScore("cl0wns!!");
      Assert.AreEqual(false, badScrabbleScore.IsValid());
    }
  }
}