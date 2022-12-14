using System;
using System.Collections.Generic;

namespace ZH_ASWYGE.Models;

public partial class Raktar
{
    public int RaktarKod { get; set; }

    public string RaktarNev { get; set; } = null!;

    public string RaktarCim { get; set; } = null!;

    public virtual ICollection<Termek> Termek { get; } = new List<Termek>();
}
