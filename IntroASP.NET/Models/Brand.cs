using System;
using System.Collections.Generic;

namespace IntroASP.NET.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    public string NameBrand { get; set; } = null!;

    public virtual ICollection<Beer> Beers { get; set; } = new List<Beer>();
}
