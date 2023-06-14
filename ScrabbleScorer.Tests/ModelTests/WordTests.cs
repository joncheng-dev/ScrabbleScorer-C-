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
      Word newWord = new Word();
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }
  }
}