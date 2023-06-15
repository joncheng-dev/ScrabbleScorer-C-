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
      Word newWord = new Word(testString);
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetUserEnteredString_ReturnUserEnteredString_String()
    {
      //Arrange
      string someWord = "SCRAM";
      Word newWord = new Word(someWord);
      //Act
      string result = newWord.GetUserEnteredString();
      //Assert
      Assert.AreEqual(someWord, result);
    }

    [TestMethod]
    public void SetUserEnteredString_SetsUserEnteredString_Void()
    {
      //Arrange
      Word newWord = new Word("BLE");
      string aString = "SCRAM";
      //Act
      newWord.SetUserEnteredString(aString);
      //Assert
      Assert.AreEqual(aString, newWord.GetUserEnteredString());
    }    
  }
}