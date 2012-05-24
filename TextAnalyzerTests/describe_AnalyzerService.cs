using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TextAnalyzer.Analyzer;

namespace TextAnalyzerTests
{
    public class describe_AnalyzerService
    {
        private TextAnalyzerService _analyzer;

        [SetUp]
        public void CreateSenders()
        {
            _analyzer = new TextAnalyzerService();
        }

        [Test]
        public void Count_letters_should_count_each_letter_occurence()
        {
            // arrange
            var text = "aaabbbcc";

            // act
            Dictionary<char, int> result = _analyzer.CountLetters(text);

            // assert
            Assert.AreEqual(result['a'], 3);
            Assert.AreEqual(result['b'], 3);
            Assert.AreEqual(result['c'], 2);

        }

        [Test]
        public void Count_letters_should_ignore_case()
        {
            // arrange
            var text = "aAabBBcC";

            // act
            Dictionary<char, int> result = _analyzer.CountLetters(text);

            // assert
            Assert.AreEqual(result['a'], 3);
            Assert.AreEqual(result['b'], 3);
            Assert.AreEqual(result['c'], 2);

        }

        [Test]
        public void Count_letters_should_ignore_whiteSpace_punctuation()
        {
            // arrange
            var text = "a1Aa+bB , B_cC";

            // act
            Dictionary<char, int> result = _analyzer.CountLetters(text);

            // assert
            Assert.AreEqual(result['a'], 3);
            Assert.AreEqual(result['b'], 3);
            Assert.AreEqual(result['c'], 2);

        }
    }
}
