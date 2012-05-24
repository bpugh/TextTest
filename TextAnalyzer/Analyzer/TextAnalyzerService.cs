using System.Collections.Generic;

namespace TextAnalyzer.Analyzer
{
    public class TextAnalyzerService : ITextAnalyzerService
    {
        /// <summary>
        /// Counts the occurences of each letter found in specified text.
        /// </summary>
        /// <param name="text">The text to analyze.</param>
        /// <returns>Dictionary with an entry for each letter found in text</returns>
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

    }
}