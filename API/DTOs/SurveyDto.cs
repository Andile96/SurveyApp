using System;

namespace API.DTOs;

public class SurveyDto
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Age { get; set; }
    public List<string> FavoriteFoods { get; set; } = new();
    public int EatOutRating { get; set; }
    public int WatchMoviesRating { get; set; }
    public int WatchTvRating { get; set; }
    public int ListenRadioRating { get; set; }
}
