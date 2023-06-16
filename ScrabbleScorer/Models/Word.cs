using System.Collections.Generic;

namespace ScrabbleScorer.Models
{
  public class Word
  {
    private string _userEnteredString;
    public int WordScore { get; set; }

    // Constructor
    public Word(string someString)
    {
      _userEnteredString = someString;      
    }
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

    public int ScoreCounter(string stringAlphasOnly)
    {
      // Set up
      int score = 0;
      string capitalizedString = stringAlphasOnly.ToUpper();
      // Calculate
      for (int i = 0; i < capitalizedString.Length; i++)
      {
        Word.letterScoreTable.TryGetValue(capitalizedString[i], out int characterPointValue);
        score += characterPointValue;
      }
      // Return result
      return score;
    }

    static Dictionary<char, int> letterScoreTable = new Dictionary<char, int>()
    {
      {'A', 1},
      {'E', 1},      
      {'I', 1},
      {'O', 1},
      {'U', 1},
      {'L', 1},
      {'N', 1},      
      {'R', 1},
      {'S', 1},
      {'T', 1},
      {'D', 2},
      {'G', 2},
      {'B', 3},
      {'C', 3},            
      {'M', 3},
      {'P', 3},
      {'F', 4},                  
      {'H', 4},
      {'V', 4},                  
      {'W', 4},
      {'Y', 4},
      {'K', 5},
      {'J', 8},
      {'X', 8},
      {'Q', 10},
      {'Z', 10},                        
    };
  }
}