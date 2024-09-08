using System.Text;
using Azure;
using Azure.AI.TextAnalytics;
using Microsoft.Extensions.Options;

namespace TextAnalyticsWStrategyPattern.Analytics;



public class AzureTextAnalyticsTextAnalyzer : ITextAnalyzer
{
    private readonly TextAnalyticsClient _client;

    public AzureTextAnalyticsTextAnalyzer(IOptions<AzureTextAnalyticsSettings> settings)
    {
        var endpoint = settings.Value.Endpoint;
        var apiKey = settings.Value.ApiKey;
        _client = AuthenticateClient(endpoint, apiKey);
    }

    public async Task<string> AnalyzeSentiment(string text)
    {
        var sentimentResult = await _client.AnalyzeSentimentAsync(text, "tr");
        var result = new StringBuilder();

        foreach (var sentence in sentimentResult.Value.Sentences)
        {
            result.AppendLine("Azure Analyze");

            if (sentence.Sentiment == TextSentiment.Positive)
            {
                result.AppendLine("Sentiment: Positive");
            }
            else if (sentence.Sentiment == TextSentiment.Negative)
            {
                result.AppendLine("Sentiment: Negative");
            }
            else
            {
                result.AppendLine("Sentiment: Neutral");
            }
        }

        return result.ToString();
    }

    private TextAnalyticsClient AuthenticateClient(string endpoint, string apiKey)
    {
        var credentials = new AzureKeyCredential(apiKey);
        var client = new TextAnalyticsClient(new Uri(endpoint), credentials);
        return client;
    }
}