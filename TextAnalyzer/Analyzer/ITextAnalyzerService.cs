using System.Collections.Generic;
using TextAnalyzer.Controllers;
using TextAnalyzer.Models;

namespace TextAnalyzer.Analyzer
{
    public interface ITextAnalyzerService
    {
        Dictionary<char, int> CountLetters(string text);
        TextAnalysis AnalyzeText(string text);
    }
}