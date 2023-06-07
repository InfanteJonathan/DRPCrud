using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class Login
{
    public int LoginId { get; set; }

    public int? UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? CorreoElectronico { get; set; }

    public virtual Usuario? User { get; set; }
}
