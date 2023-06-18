using System;
using ScrabbleScorer.Models;

namespace ScrabbleScorer
{
  class Program 
  {
    static void Main()
    {
      bool? validInput = null;
      do
      {
        Console.WriteLine("*~*~*~*~*~**~*~*~*~*~**~*~*~*~**~*~*~*~*~*~**~*~*~*~*~*~**~*~*~*~*~**~*~*~*~*~*~*~*");
        Console.WriteLine("Enter a word -- alphabet characters, no spaces -- to calculate its Scrabble score: ");
        Console.WriteLine("*~*~*~*~*~**~*~*~*~*~**~*~*~*~**~*~*~*~*~*~**~*~*~*~*~*~**~*~*~*~*~**~*~*~*~*~*~*~*");

        Word userEnteredWord = new Word(Console.ReadLine());

        Console.WriteLine($"The word you entered is: {userEnteredWord.GetUserEnteredString()}");

        if (userEnteredWord.InputVerifier(userEnteredWord.GetUserEnteredString()))
        {
          validInput = true;
          int result = userEnteredWord.ScoreCounter(userEnteredWord.GetUserEnteredString());
          Console.WriteLine($"{userEnteredWord.GetUserEnteredString()} has {result} points");
        }
        else
        {
          Console.WriteLine("Invalid entry. Enter a word -- alphabet characters only, no spaces: ");
        }
      }
      while (validInput != true);
    }
  }
}