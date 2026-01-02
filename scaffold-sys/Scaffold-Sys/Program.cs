using SKA_Holding.Data;
using SKA_Holding.Models;

Movie movie = new Movie()
{
    Title = "Inception",
    ReleaseYear = 2010,
    Duration = 148,
    Rating = 8.8m,
    Description = "A mind-bending thriller about dreams.",
    DirectorId = 1,
    ScreenWriterId = 1
};

ImdbContext dbContext = new();
await CreateMovie(dbContext, movie);

Movie savedMovie = ReadMovies(dbContext, 1);
Console.WriteLine(savedMovie.Title);
static async Task CreateMovie(ImdbContext dbContext, Movie movie)
{
    dbContext.Add(movie);
    await dbContext.SaveChangesAsync();
}

static Movie ReadMovies(ImdbContext dbContext, int id)
{
    var result = dbContext.Movie.Find(id);

    if (result != null)
    {
        return result;
    }
    throw new ArgumentOutOfRangeException(nameof(id));
}
