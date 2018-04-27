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

        RepeatCounter newWord = new RepeatCounter("hello");
        Assert.AreEqual("hello", newWord.GetWord());
        }
    }
}
