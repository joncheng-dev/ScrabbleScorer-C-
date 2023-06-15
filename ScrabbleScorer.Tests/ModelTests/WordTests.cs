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
  }
}