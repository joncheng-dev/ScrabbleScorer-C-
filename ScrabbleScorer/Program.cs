using System;
using ScrabbleScorer.Models;

namespace ScrabbleScorer
{
  class Program 
  {
    static void Main()
    {
      Word testWord = new Word("SPARK");
      Console.WriteLine(testWord.GetType());

      testWord.SetUserEnteredString("COURAGE");

      Console.WriteLine($"First word is: {testWord.GetUserEnteredString()}");
    }
  }
}