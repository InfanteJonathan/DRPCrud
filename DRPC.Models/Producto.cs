using System;
using System.Collections.Generic;

namespace DRPC.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int? CategoriaId { get; set; }

    public decimal? Precio { get; set; }

    public int? CantidadStock { get; set; }

    public string? Imagen { get; set; }

    public virtual ICollection<Accesorio> Accesorios { get; set; } = new List<Accesorio>();

    public virtual ICollection<CarritoCompra> CarritoCompras { get; set; } = new List<CarritoCompra>();

    public virtual Categoria? Categoria { get; set; }

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual ICollection<DetallesFactura> DetallesFacturas { get; set; } = new List<DetallesFactura>();

    public virtual ICollection<DetallesPedido> DetallesPedidos { get; set; } = new List<DetallesPedido>();

    public virtual ICollection<DetallesVentum> DetallesVenta { get; set; } = new List<DetallesVentum>();

    public virtual ICollection<Garantia> Garantia { get; set; } = new List<Garantia>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();
}
