using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;

namespace WordCounter.Models
{
  public class Word
  {
    private string _playerName;
    private string _inputWord;
    private string _inputSentence;
    public static int ResultNumber = 0;
    
    public Word(string playerName, string inputWord, string inputSentence)
    {
      _playerName = playerName;
      _inputWord = inputWord;
      _inputSentence = inputSentence;
    }

    public string GetName()
    {
      return _playerName;
    }
    public string GetInputWord()
    {
      return _inputWord;
    }
    public string GetSentence()
    {
      return _inputSentence;
    }
    public string [] AssignWordSentence()
    {
      string words = _inputSentence.Split(' ');
      return words;
    }

    public int GetAllNumbers()
    {
      return ResultNumber;
    }
    public int CheckWordCounter()
    {
    
      string [] words = this.AssignWordSentence();
      for (int i = 0; i < words.Length; i ++)
      {
        ResultNumber = (words[i].Equals(_targetWord)) ? ++ResultNumber:ResultNumber;
        words[i] = (words[i].Equals(_targetWord)) ? "<mark>" + words[i] + "</mark>" : words[i]; 
      }

      return ResultNumber;
    }
    public static void ClearAll()
    {
      ResultNumber = 0;
    }
  }
}
// System.Console.WriteLine()
