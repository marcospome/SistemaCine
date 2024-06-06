using System;
using System.Collections.Generic;

namespace semana4.Models;

public partial class Permiso
{
    public int Idpermiso { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Rol> Idrols { get; set; } = new List<Rol>();
}
