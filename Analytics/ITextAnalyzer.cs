namespace TextAnalyticsWStrategyPattern.Analytics;

public interface ITextAnalyzer
{
    Task<string> AnalyzeSentiment(string text);
}