using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextAnalyzer.Analyzer;
using TextAnalyzer.Models;

namespace TextAnalyzer.Controllers
{
    public class HomeController : Controller
    {
        private ITextAnalyzerService _textAnalyzer;

        public HomeController(ITextAnalyzerService textAnalyzer)
        {
            _textAnalyzer = textAnalyzer;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Please enter text to analyze.";

            return View();
        }

        [HttpPost]
        public ActionResult AnalyzeText(string textToAnalyze)
        {
            var result = new TextAnalysis();
            result.LetterCounts = _textAnalyzer.CountLetters(textToAnalyze);
            return View(result);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
