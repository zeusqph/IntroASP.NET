using System;
using System.Collections.Generic;

namespace IntroASP.NET.Models;

public partial class Beer
{
    public int BeerId { get; set; }

    public string NameBeer { get; set; } = null!;

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
