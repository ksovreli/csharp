using System;
using System.Collections.Generic;

namespace SKA_Holding.Models;

public partial class Movie
{
    public int MovieId { get; set; }

    public int DirectorId { get; set; }

    public int ScreenWriterId { get; set; }

    public string Title { get; set; } = null!;

    public int? ReleaseYear { get; set; }

    public int? Duration { get; set; }

    public decimal? Rating { get; set; }

    public string? Description { get; set; }

    public virtual MovieDirector Director { get; set; } = null!;

    public virtual ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();

    public virtual ScreenWriter ScreenWriter { get; set; } = null!;

    public virtual ICollection<Actor> Actors { get; set; } = new List<Actor>();
}
