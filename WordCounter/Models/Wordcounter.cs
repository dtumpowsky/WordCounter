using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;

        public RepeatCounter(string word)
        {
            _word = word;
        }

        public string GetWord()
        {
            return _word;
        }
    }
}    
