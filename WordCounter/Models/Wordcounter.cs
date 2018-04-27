using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _sentence;
        private int _instance = 0;

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

        public int GetInstance()
        {
            return _instance;
        }


        public void CountWords()
        {
            _instance = 0;
            string[] sentenceInput = _sentence.Split(' ');
            for(int i=0; i < sentenceInput.Length; i++)
            {
                if (sentenceInput[i] == _word)
                {
                    _instance+=1;
                }
                else
                {

                }
            }
        }
    }
}
