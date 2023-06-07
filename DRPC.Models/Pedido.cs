using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class Pedido
{
    public int PedidoId { get; set; }

    public int? UserId { get; set; }

    public DateTime? FechaPedido { get; set; }

    public string? Estado { get; set; }

    public string? DireccionEnvio { get; set; }

    public int? MetodoPagoId { get; set; }

    public virtual ICollection<DetallesPedido> DetallesPedidos { get; set; } = new List<DetallesPedido>();

    public virtual MetodosPago? MetodoPago { get; set; }

    public virtual Usuario? User { get; set; }
}
