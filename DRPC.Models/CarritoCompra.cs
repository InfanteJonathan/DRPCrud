using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class CarritoCompra
{
    public int CarritoId { get; set; }

    public int? UserId { get; set; }

    public int? ProductoId { get; set; }

    public int? Cantidad { get; set; }

    public virtual Producto? Producto { get; set; }

    public virtual Usuario? User { get; set; }
}
