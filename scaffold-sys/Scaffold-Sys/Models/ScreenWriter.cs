using System;
using System.Collections.Generic;

namespace SKA_Holding.Models;

public partial class ScreenWriter
{
    public int ScreenWriterId { get; set; }

    public string ScreenWriterName { get; set; } = null!;

    public string ScreenWriterSurname { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
