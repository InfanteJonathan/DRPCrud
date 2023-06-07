using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class Inventario
{
    public int InventarioId { get; set; }

    public int? ProductoId { get; set; }

    public int? CantidadDisponible { get; set; }

    public string? Estado { get; set; }

    public string? Ubicacion { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? Proveedor { get; set; }

    public virtual Producto? Producto { get; set; }
}
