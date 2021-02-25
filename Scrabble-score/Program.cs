using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    public static void Main(){
      Console.Write("Enter in a word for Scrabble: ");
      string userInput = Console.ReadLine();
      Console.ForegroundColor  = ConsoleColor.Green;
      Console.WriteLine(ScrabbleScore.WordScore(userInput));
    }
  }
}