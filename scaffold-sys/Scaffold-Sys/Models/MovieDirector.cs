using System;
using System.Collections.Generic;

namespace SKA_Holding.Models;

public partial class MovieDirector
{
    public int DirectorId { get; set; }

    public string DirectorName { get; set; } = null!;

    public string DirectorSurname { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
