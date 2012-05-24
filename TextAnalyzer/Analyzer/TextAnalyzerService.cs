using System.Collections.Generic;
using TextAnalyzer.Controllers;
using TextAnalyzer.Models;

namespace TextAnalyzer.Analyzer
{
    public class TextAnalyzerService : ITextAnalyzerService
    {
        public Dictionary<char, int> CountLetters(string text)
        {
            var counts = new Dictionary<char, int>();
            foreach (char c in text.ToLower())
            {
                if (char.IsLetter(c))
                {
                    if (counts.ContainsKey(c))
                    {
                        counts[c]++;
                    }
                    else
                    {
                        counts.Add(c, 1);
                    }
                }
            }

            return counts;
        }

        public TextAnalysis AnalyzeText(string text)
        {
            var result = new TextAnalysis();
            result.LetterCounts = CountLetters(text);
            return result;
        }
    }
}