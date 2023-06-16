using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      string testString = "HELLO";
      int testScore = 2;
      Word newWord = new Word(testString, testScore);
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetUserEnteredString_ReturnUserEnteredString_String()
    {
      //Arrange
      string someWord = "SCRAM";
      int testScore = 2;      
      Word newWord = new Word(someWord, testScore);
      //Act
      string result = newWord.GetUserEnteredString();
      //Assert
      Assert.AreEqual(someWord, result);
    }

    [TestMethod]
    public void SetUserEnteredString_SetsUserEnteredString_Void()
    {
      //Arrange
      int testScore = 2;
      Word newWord = new Word("BLE", testScore);
      string aString = "SCRAM";
      //Act
      newWord.SetUserEnteredString(aString);
      //Assert
      Assert.AreEqual(aString, newWord.GetUserEnteredString());
    }

    [TestMethod]
    public void GetWordScore_ReturnWordScore_Int()
    {
      //Arrange
      int aScoreValue = 10;
      Word newWord = new Word("BLE", aScoreValue);
      //Act
      int result = newWord.WordScore;
      //Assert
      Assert.AreEqual(aScoreValue, result);
    }

    [TestMethod]
    public void SetWordScore_SetsWordScore_Void()
    {
      //Arrange
      Word newWord = new Word("BLE", 10);
      int aNewScoreValue = 500;
      //Act
      newWord.WordScore = aNewScoreValue;
      //Assert
      Assert.AreEqual(aNewScoreValue, newWord.WordScore);
    }

    [TestMethod]
    public void ScoreCounter_ReturnsWordScoreForA_Void()
    {
      //Arrange
      Word newWord = new Word("A");
      int actualWordScore = 1;
      //Act
      int methodResult = newWord.ScoreCounter(newWord.GetUserEnteredString());
      //Assert
      Assert.AreEqual(actualWordScore, methodResult);
    } 

    [TestMethod]
    public void ScoreCounter_ReturnsWordScoreForHELLO_Void()
    {
      //Arrange
      Word newWord = new Word("HELLO");
      int actualWordScore = 8;
      //Act
      int methodResult = newWord.ScoreCounter(newWord.GetUserEnteredString());
      //Assert
      Assert.AreEqual(actualWordScore, methodResult);
    } 

  }
}