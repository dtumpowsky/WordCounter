using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void RecognizeWord_String_True()
        {

        RepeatCounter newWord = new RepeatCounter("hello","hello there friend");
        Assert.AreEqual("hello", newWord.GetWord());
        }

        [TestMethod]
        public void RecognizeSentence_String()
        {

        RepeatCounter newSentence = new RepeatCounter("hello","hello there friend");
        Assert.AreEqual("hello there friend", newSentence.GetSentence());
        }
    }
}
