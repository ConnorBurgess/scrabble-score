using System;
using System.Collections.Generic;
namespace Scrabble.Models
{
  public class ScrabbleScore
  {
    public static Dictionary<int, string> scrabbleScoreBoard = new Dictionary<int, string>() {
      {1, "aeioulnrst"},
      {2, "dg"},
      {3, "bcmp"},
      {4, "fhvwy"},
      {5, "k"},
      {8, "jx"},
      {10, "qz"}
    };

    public static int WordScore(string word) {
      int total = 0;
      for (int i = 0; i < word.Length; i++) {
        char tempWord = Char.ToLower(word[i]);
        foreach(KeyValuePair<int, string> obj in scrabbleScoreBoard) {
          // Console.WriteLine($"Key: {obj.Key} | Value: {obj.Value}");
          bool contains = obj.Value.Contains(tempWord);
          if(contains) {
            total += obj.Key;
          }
        }
      }
      return total;
    }
  }
}