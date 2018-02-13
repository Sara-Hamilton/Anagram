using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class AnagramGenerator
  {
    public bool IsAnagram(string wordOne, string wordTwo)
    {
      for (int i = 0; i < wordOne.Length; i++)
      {
        if (!wordTwo.Contains(wordOne[i].ToString()))
        {
          return false;
        }
      }
      return true;
    }

    // public List<bool> AnagramList(string comparisonWord, List<string> wordList)
    // {
    //   List<bool> result = new List<bool>();
    //   foreach (string word in wordList)
    //   {
    //     result.Add(IsAnagram(comparisonWord, word));
    //   }
    //   return result;
    // }

    public List<string> ReturnAnagramMatches(string comparisonWord, List<string> wordList)
    {
      List<string> result = new List<string>();
      foreach (string word in wordList)
      {
        if (IsAnagram(comparisonWord, word))
        {
          result.Add(word);
        }
      }
      return result;
    }

  }
}
