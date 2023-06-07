using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class Factura
{
    public int FacturaId { get; set; }

    public int? VentaId { get; set; }

    public DateTime? FechaFactura { get; set; }

    public string? NumeroFactura { get; set; }

    public virtual ICollection<DetallesFactura> DetallesFacturas { get; set; } = new List<DetallesFactura>();

    public virtual Venta? Venta { get; set; }
}
