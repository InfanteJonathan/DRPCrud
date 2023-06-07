using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class Usuario
{
    public int UserId { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Contacto { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Contraseña { get; set; }

    public virtual ICollection<CarritoCompra> CarritoCompras { get; set; } = new List<CarritoCompra>();

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual ICollection<Login> Logins { get; set; } = new List<Login>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
