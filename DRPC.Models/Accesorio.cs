using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class Accesorio
{
    public int AccesorioId { get; set; }

    public int? ProductoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Precio { get; set; }

    public virtual Producto? Producto { get; set; }
}
