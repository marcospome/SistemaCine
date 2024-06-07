using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace semana4.Models;

public partial class Usuario : IdentityUser
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }


}