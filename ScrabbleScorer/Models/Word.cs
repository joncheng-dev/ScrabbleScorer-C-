
namespace ScrabbleScorer.Models
{
  public class Word
  {
    private string _userEnteredString;
    public int wordScore;

    // Constructor
    public Word(string someString)
    {
      _userEnteredString = someString;
    }

    // Get method
    public string GetUserEnteredString()
    {
      return _userEnteredString;
    }

    // Set method
    public void SetUserEnteredString(string newString)
    {
      _userEnteredString = newString;
    }
  }
}