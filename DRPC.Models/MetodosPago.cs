using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class MetodosPago
{
    public int MetodoPagoId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
