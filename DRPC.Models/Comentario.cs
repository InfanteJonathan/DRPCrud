using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class Comentario
{
    public int ComentarioId { get; set; }

    public int? ProductoId { get; set; }

    public int? UserId { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Calificacion { get; set; }

    public string? Comentario1 { get; set; }

    public virtual Producto? Producto { get; set; }

    public virtual Usuario? User { get; set; }
}
