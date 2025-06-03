using System;

namespace API.DTOs;

public class CalculateStatsDto
{
    public int TotalSurveys { get; set; }
    public double AverageAge { get; set; }
    public int OldestAge { get; set; }
    public int YoungestAge { get; set; }
    public double PizzaPercentage { get; set; }
    public double PastaPercentage { get; set; }
    public double PapAndWorsPercentage { get; set; }
    public double OtherFoodPercentage { get; set; }
    public double WatchingMoviesAverage { get; set; }
    public double ListeningRadioAverage { get; set; }
    public double EatingOutAverage { get; set; }
    public double WatchingTvAverage { get; set; }
}
