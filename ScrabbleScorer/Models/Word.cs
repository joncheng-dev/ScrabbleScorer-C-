
namespace ScrabbleScorer.Models
{
  public class Word
  {
    private string _userEnteredString;
    public int WordScore { get; }

    // Constructor
    public Word(string someString, int someScoreValue)
    {
      _userEnteredString = someString;
      WordScore = someScoreValue;
    }

    // Get method for user entered string
    public string GetUserEnteredString()
    {
      return _userEnteredString;
    }

    // Set method for user entered string
    public void SetUserEnteredString(string newString)
    {
      _userEnteredString = newString;
    }
  }
}