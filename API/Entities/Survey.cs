namespace API.Entities;

public class Survey
{
    public int Id { get; set; }
    public string FullNames { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Age { get; set; }
    public List<string> FavoriteFoods { get; set; } = new();
    public int EatingOutRating { get; set; }
    public int WatchingMoviesRating { get; set; }
    public int ListeningRadioRating { get; set; }
    public int WatchingTvRating { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

}
