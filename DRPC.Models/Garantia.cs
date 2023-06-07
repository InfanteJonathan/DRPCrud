using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class Garantia
{
    public int GarantiaId { get; set; }

    public int? ProductoId { get; set; }

    public int? DuracionMeses { get; set; }

    public string? Descripcion { get; set; }

    public virtual Producto? Producto { get; set; }
}
