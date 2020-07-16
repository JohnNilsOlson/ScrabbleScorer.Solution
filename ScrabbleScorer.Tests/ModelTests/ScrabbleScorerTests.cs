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

    [TestMethod]
    public void ToLowerArray_BreakWordIntoLetterArray_Match()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("SCRABBLE");
      char[] expectedArray = { 's', 'c', 'r', 'a', 'b', 'b', 'l', 'e' };
      CollectionAssert.AreEqual(expectedArray, newScrabbleScore.ToLowerArray());
    }

    [TestMethod]
    public void ScoreCounter_IncreaseScoreBy1ForAEIOULNRST_Match()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("line");
      newScrabbleScore.ScoreCounter();
      Assert.AreEqual(4, newScrabbleScore.Score);
    }

    [TestMethod]
    public void ScoreCounter_IncreaseScoreBy2ForDG_Match()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("dog");
      newScrabbleScore.ScoreCounter();
      Assert.AreEqual(5, newScrabbleScore.Score);
    }

    [TestMethod]
    public void ScoreCounter_IncreaseScoreBy3ForBCMP_Match()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("bcmp");
      newScrabbleScore.ScoreCounter();
      Assert.AreEqual(12, newScrabbleScore.Score);
    }

    [TestMethod]
    public void ScoreCounter_IncreaseScoreBy4ForFHVWY_Match()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("fhvwy");
      newScrabbleScore.ScoreCounter();
      Assert.AreEqual(20, newScrabbleScore.Score);
    }

    [TestMethod]
    public void ScoreCounter_IncreaseScoreBy5ForK_Match()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("k");
      newScrabbleScore.ScoreCounter();
      Assert.AreEqual(5, newScrabbleScore.Score);
    }

    [TestMethod]
    public void ScoreCounter_IncreaseScoreBy8ForJX_Match()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("jx");
      newScrabbleScore.ScoreCounter();
      Assert.AreEqual(16, newScrabbleScore.Score);
    }

    [TestMethod]
    public void ScoreCounter_IncreaseScoreBy10ForQZ_Match()
    {
      ScrabbleScore newScrabbleScore = new ScrabbleScore("qz");
      newScrabbleScore.ScoreCounter();
      Assert.AreEqual(20, newScrabbleScore.Score);
    }
  }
}