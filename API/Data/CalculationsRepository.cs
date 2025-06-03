using System;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class CalculationsRepository(DataContext context) : ICalculationsRepository
{

    public async Task<CalculateStatsDto> GetSurveyStatsAsync()
    {
        var surveys = await context.Surveys.ToListAsync();
        if (!surveys.Any()) return null;

        return new CalculateStatsDto
        {
            TotalSurveys = surveys.Count,
            AverageAge = Math.Round(surveys.Average(r => r.Age), 1),
            OldestAge = surveys.Max(r => r.Age),
            YoungestAge = surveys.Min(r => r.Age),
            PizzaPercentage = Math.Round(surveys.Count(r => r.FavoriteFoods.Contains("Pizza")) * 100.0 / surveys.Count, 1),
            PastaPercentage = Math.Round(surveys.Count(r => r.FavoriteFoods.Contains("Pasta")) * 100.0 / surveys.Count),
            PapAndWorsPercentage = Math.Round(surveys.Count(r => r.FavoriteFoods.Contains("Pap And Wors")) * 100.0 / surveys.Count),
            OtherFoodPercentage = Math.Round(surveys.Count(r => r.FavoriteFoods.Contains("Other")) * 100.0 / surveys.Count),
            WatchingMoviesAverage = Math.Round(surveys.Average(r => r.WatchingMoviesRating)),
            ListeningRadioAverage = Math.Round(surveys.Average(r => r.ListeningRadioRating)),
            EatingOutAverage = Math.Round(surveys.Average(r => r.EatingOutRating),1),
            WatchingTvAverage = Math.Round(surveys.Average(r => r.WatchingTvRating))
        };
        
        
    }

}
