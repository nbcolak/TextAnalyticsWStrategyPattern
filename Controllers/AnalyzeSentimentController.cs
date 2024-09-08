using Microsoft.AspNetCore.Mvc;
using TextAnalyticsWStrategyPattern.Analytics;

[ApiController]
[Route("api/[controller]")]
public class AnalyzeSentimentController : ControllerBase
{
    private readonly ITextAnalyzer _textAnalyzer;

    public AnalyzeSentimentController(ITextAnalyzer textAnalyzer)
    {
        _textAnalyzer = textAnalyzer;
    }

    [HttpPost]
    public async Task<IActionResult> AnalyzeSentiment([FromBody] string text)
    {
        var result = await _textAnalyzer.AnalyzeSentiment(text);
        return Ok(result);
    }
}