using System;
using System.Collections.Generic;

namespace ZH_ASWYGE.Models;

public partial class RendelesTetel
{
    public int Sorszam { get; set; }

    public string Termekkod { get; set; } = null!;

    public double? Egysegar { get; set; }

    public double Mennyiseg { get; set; }

    public virtual Rendeles SorszamNavigation { get; set; } = null!;

    public virtual Termek TermekkodNavigation { get; set; } = null!;
}
