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

    private static int _auto_increment_id = 0;
    private static List<RepeatCounter> _counters = new List<RepeatCounter>{};
    
    public Word(string playerName, string inputWord, string inputSentence)
    {
      _playerName = playerName;
      _inputWord = inputWord;
      _inputSentence = inputSentence;
      _id = _auto_increment_id++;
      _counters.Add(this);
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
    public int GetId()
    {
      return _id;
    }
    public static int GetAutoIncrementId()
    {
      return _auto_increment_id;
    }

    public static string InputValidator(string targetWord, string sentence)
    {
      targetWord = targetWord.Trim();
      sentence = sentence.Trim();
      string errorMessage = "";
      if (targetWord == "" && sentence == "")
        errorMessage += "Target word and sentence";
      else if (targetWord == "")
        errorMessage += "Target word ";
      else if (sentence == "")
        errorMessage += "Sentence ";
      if (!string.Equals(errorMessage, ""))
        errorMessage += "cannot be empthy.";
      return errorMessage;
    }
    public string [] AssignWordSentence()
    {
      string [] words = _inputSentence.Split(' ');
      return words;
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
