using System;
using System.Collections.Generic;

namespace ZH_ASWYGE.Models;

public partial class Rendeles
{
    public int Sorszam { get; set; }

    public string? Login { get; set; }

    public DateTime? RendDatum { get; set; }

    public DateTime? SzallDatum { get; set; }

    public string? SzallCim { get; set; }

    public string? SzallMod { get; set; }

    public string? FizMod { get; set; }

    public string? SzamlaCim { get; set; }

    public virtual Ugyfel? LoginNavigation { get; set; }

    public virtual ICollection<RendelesTetel> RendelesTetel { get; } = new List<RendelesTetel>();
}
