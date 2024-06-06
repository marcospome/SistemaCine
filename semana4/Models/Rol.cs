using System;
using System.Collections.Generic;

namespace semana4.Models;

public partial class Rol
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual ICollection<Permiso> Idpermisos { get; set; } = new List<Permiso>();
}
