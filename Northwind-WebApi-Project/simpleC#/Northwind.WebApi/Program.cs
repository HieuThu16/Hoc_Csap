using Microsoft.AspNetCore.HttpLogging; // To use HttpLoggingFields.

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.All;
    options.RequestBodyLogLimit = 4096; // Default is 32k.
    options.ResponseBodyLogLimit = 4096; // Default is 32k.
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpLogging();

app.UseHttpsRedirection();

app.MapGet("/weatherforecast/{days:int?}",
    (int days = 5) => Program.GetWeather(days))
    .WithName("GetWeatherForecast");

app.Run();

public partial class Program
{
    static string[] summaries = { "Freezing", "Bracing",
        "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot",
        "Sweltering", "Scorching" };
    
    internal static WeatherForecast[]? GetWeather(int days)
    {
        WeatherForecast[]? forecast = Enumerable.Range(1, days)
            .Select(index => new WeatherForecast
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                summaries[Random.Shared.Next(summaries.Length)]
            ))
            .ToArray();
        return forecast;
    }
    
    internal record WeatherForecast(DateOnly Date,
        int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 +
            (int)(TemperatureC / 0.5556);
    }
}
