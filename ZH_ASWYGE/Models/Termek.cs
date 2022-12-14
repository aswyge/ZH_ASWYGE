using System;
using System.Collections.Generic;

namespace ZH_ASWYGE.Models;

public partial class Termek
{
    public string Termekkod { get; set; } = null!;

    public string? Megnevezes { get; set; }

    public int? KatId { get; set; }

    public double? Listaar { get; set; }

    public string? Leiras { get; set; }

    public int? RaktarKod { get; set; }

    public double? Keszlet { get; set; }

    public string? Megys { get; set; }

    public string? Felvitte { get; set; }

    public DateTime? Felvitel { get; set; }

    public virtual Termekkategoria? Kat { get; set; }

    public virtual Raktar? RaktarKodNavigation { get; set; }

    public virtual ICollection<RendelesTetel> RendelesTetel { get; } = new List<RendelesTetel>();
}
