using Google.Cloud.Language.V1;
using Google.Apis.Auth.OAuth2;
using System.Text;
using Microsoft.Extensions.Options;

namespace TextAnalyticsWStrategyPattern.Analytics;

public class GoogleTextAnalyticsTextAnalyzer : ITextAnalyzer
{
    private readonly LanguageServiceClient _client;

    public GoogleTextAnalyticsTextAnalyzer(IOptions<GoogleApiSettings> settings)
    {
        string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), settings.Value.CredentialsFilePath);

        var credential = GoogleCredential.FromFile(jsonPath);

        _client = new LanguageServiceClientBuilder
        {
            Credential = credential
        }.Build();
    }

    public async Task<string> AnalyzeSentiment(string text)
    {
        var document = Document.FromPlainText(text);
        var response = await _client.AnalyzeSentimentAsync(document);

        var result = new StringBuilder();
    
        var sentimentScore = response.DocumentSentiment.Score;
        result.AppendLine("Google Analyze");

        if (sentimentScore > 0)
        {
            result.AppendLine("Sentiment: Positive");
        }
        else if (sentimentScore < 0)
        {
            result.AppendLine("Sentiment: Negative");
        }
        else
        {
            result.AppendLine("Sentiment: Neutral");
        }

        //result.AppendLine($"Sentiment Score: {response.DocumentSentiment.Score}");
        //result.AppendLine($"Sentiment Magnitude: {response.DocumentSentiment.Magnitude}");

        return result.ToString();
    }
}