using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class Venta
{
    public int VentaId { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? FechaVenta { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetallesVentum> DetallesVenta { get; set; } = new List<DetallesVentum>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Usuario? Usuario { get; set; }
}
