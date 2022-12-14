using System;
using System.Collections.Generic;

namespace ZH_ASWYGE.Models;

public partial class Ugyfel
{
    public string Login { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Nev { get; set; } = null!;

    public int? Szulev { get; set; }

    public string? Nem { get; set; }

    public string? Cim { get; set; }

    public virtual ICollection<Rendeles> Rendeles { get; } = new List<Rendeles>();
}
