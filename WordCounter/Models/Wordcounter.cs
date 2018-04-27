using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _sentence;

        public RepeatCounter(string word, string sentence)
        {
            _word = word;
            _sentence = sentence;
        }

        public string GetWord()
        {
            return _word;
        }

        public string GetSentence()
        {
            return _sentence;
        }
    }
}
