using System.Collections.Generic;

namespace TextAnalyzer.Analyzer
{
    public class TextAnalyzerService
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
    }
}