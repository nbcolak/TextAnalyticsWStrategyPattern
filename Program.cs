
using TextAnalyticsWStrategyPattern.Analytics;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<GoogleApiSettings>(builder.Configuration.GetSection("GoogleApiSettings"));
builder.Services.AddScoped<ITextAnalyzer>(sp =>
{
    var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();

    var providerHeader = httpContextAccessor.HttpContext?.Request.Headers["Provider"].FirstOrDefault();

    if (string.IsNullOrEmpty(providerHeader)) 
        return sp.GetRequiredService<GoogleTextAnalyticsTextAnalyzer>();

    return providerHeader.ToLower() switch
    {
        "google" => sp.GetRequiredService<GoogleTextAnalyticsTextAnalyzer>(),
        "azure" => sp.GetRequiredService<AzureTextAnalyticsTextAnalyzer>(),
        _ => throw new NotImplementedException($"Analyzer for provider '{providerHeader}' not implemented.")
    };
});


builder.Services.AddScoped<GoogleTextAnalyticsTextAnalyzer>();
builder.Services.AddScoped<AzureTextAnalyticsTextAnalyzer>();


builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers();

// Bind configuration section
builder.Services.Configure<AzureTextAnalyticsSettings>(builder.Configuration.GetSection("TextAnalytics"));

var app = builder.Build();

// Enable Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers(); 

app.Run();


