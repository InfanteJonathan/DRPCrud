using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DRPC.Models;


namespace DRPC.DAL.DataContext;

public partial class DrpcvirtualContext : DbContext
{
    public DrpcvirtualContext()
    {
    }

    public DrpcvirtualContext(DbContextOptions<DrpcvirtualContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accesorio> Accesorios { get; set; }

    public virtual DbSet<CarritoCompra> CarritoCompras { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<DetallesFactura> DetallesFacturas { get; set; }

    public virtual DbSet<DetallesPedido> DetallesPedidos { get; set; }

    public virtual DbSet<DetallesVentum> DetallesVenta { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Garantia> Garantias { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<MetodosPago> MetodosPagos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accesorio>(entity =>
        {
            entity.HasKey(e => e.AccesorioId).HasName("PK__Accesori__4BCD4EA9AD15A6B6");

            entity.Property(e => e.AccesorioId).HasColumnName("AccesorioID");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

            entity.HasOne(d => d.Producto).WithMany(p => p.Accesorios)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_Accesorios_Productos");
        });

        modelBuilder.Entity<CarritoCompra>(entity =>
        {
            entity.HasKey(e => e.CarritoId).HasName("PK__CarritoC__778D580BB5EFB553");

            entity.Property(e => e.CarritoId).HasColumnName("CarritoID");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Producto).WithMany(p => p.CarritoCompras)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_CarritoCompras_Productos");

            entity.HasOne(d => d.User).WithMany(p => p.CarritoCompras)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_CarritoCompras_Usuarios");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categori__F353C1C566B9D7DD");

            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.ComentarioId).HasName("PK__Comentar__F1844958F9C63B67");

            entity.Property(e => e.ComentarioId).HasColumnName("ComentarioID");
            entity.Property(e => e.Comentario1)
                .HasMaxLength(200)
                .HasColumnName("Comentario");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Producto).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_Comentarios_Productos");

            entity.HasOne(d => d.User).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Comentarios_Usuarios");
        });

        modelBuilder.Entity<DetallesFactura>(entity =>
        {
            entity.HasKey(e => e.DetalleFacturaId).HasName("PK__Detalles__2318A41508CBD7AB");

            entity.ToTable("DetallesFactura");

            entity.Property(e => e.DetalleFacturaId).HasColumnName("DetalleFacturaID");
            entity.Property(e => e.FacturaId).HasColumnName("FacturaID");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

            entity.HasOne(d => d.Factura).WithMany(p => p.DetallesFacturas)
                .HasForeignKey(d => d.FacturaId)
                .HasConstraintName("FK_DetallesFactura_Facturas");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesFacturas)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_DetallesFactura_Productos");
        });

        modelBuilder.Entity<DetallesPedido>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__Detalles__6E19D6FAA13064A1");

            entity.ToTable("DetallesPedido");

            entity.Property(e => e.DetalleId).HasColumnName("DetalleID");
            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

            entity.HasOne(d => d.Pedido).WithMany(p => p.DetallesPedidos)
                .HasForeignKey(d => d.PedidoId)
                .HasConstraintName("FK_DetallesPedido_Pedidos");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesPedidos)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_DetallesPedido_Productos");
        });

        modelBuilder.Entity<DetallesVentum>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__Detalles__6E19D6FAEBDEE0FB");

            entity.Property(e => e.DetalleId).HasColumnName("DetalleID");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.VentaId).HasColumnName("VentaID");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesVenta)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_DetallesVenta_Productos");

            entity.HasOne(d => d.Venta).WithMany(p => p.DetallesVenta)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("FK_DetallesVenta_Ventas");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PK__Facturas__5C0248052E9C7C76");

            entity.Property(e => e.FacturaId).HasColumnName("FacturaID");
            entity.Property(e => e.FechaFactura).HasColumnType("datetime");
            entity.Property(e => e.NumeroFactura).HasMaxLength(50);
            entity.Property(e => e.VentaId).HasColumnName("VentaID");

            entity.HasOne(d => d.Venta).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("FK_Facturas_Ventas");
        });

        modelBuilder.Entity<Garantia>(entity =>
        {
            entity.HasKey(e => e.GarantiaId).HasName("PK__Garantia__3552F81414740CAB");

            entity.Property(e => e.GarantiaId).HasColumnName("GarantiaID");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

            entity.HasOne(d => d.Producto).WithMany(p => p.Garantia)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_Garantias_Productos");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.InventarioId).HasName("PK__Inventar__FB8A24B7E055CBE0");

            entity.ToTable("Inventario");

            entity.Property(e => e.InventarioId).HasColumnName("InventarioID");
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.Proveedor).HasMaxLength(50);
            entity.Property(e => e.Ubicacion).HasMaxLength(100);

            entity.HasOne(d => d.Producto).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_Inventario_Productos");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.LoginId).HasName("PK__Login__4DDA2838AE0D905D");

            entity.ToTable("Login");

            entity.Property(e => e.LoginId)
                .ValueGeneratedNever()
                .HasColumnName("LoginID");
            entity.Property(e => e.CorreoElectronico).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.User).WithMany(p => p.Logins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Login_Usuarios");
        });

        modelBuilder.Entity<MetodosPago>(entity =>
        {
            entity.HasKey(e => e.MetodoPagoId).HasName("PK__MetodosP__A8FEAF746858C798");

            entity.ToTable("MetodosPago");

            entity.Property(e => e.MetodoPagoId).HasColumnName("MetodoPagoID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.PedidoId).HasName("PK__Pedidos__09BA141049AF36AA");

            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.DireccionEnvio).HasMaxLength(100);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaPedido).HasColumnType("datetime");
            entity.Property(e => e.MetodoPagoId).HasColumnName("MetodoPagoID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.MetodoPago).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.MetodoPagoId)
                .HasConstraintName("FK_Pedidos_MetodosPago");

            entity.HasOne(d => d.User).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Pedidos_Usuarios");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AE838B1505FA");

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Imagen).HasMaxLength(200);
            entity.Property(e => e.Marca).HasMaxLength(50);
            entity.Property(e => e.Modelo).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .HasConstraintName("FK_Productos_Categorias");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Usuarios__1788CCACC348BF5F");

            entity.HasIndex(e => e.Contacto, "UQ_Usuarios_Contacto").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Contacto).HasMaxLength(50);
            entity.Property(e => e.Contraseña).HasMaxLength(100);
            entity.Property(e => e.CorreoElectronico).HasMaxLength(100);
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.VentaId).HasName("PK__Ventas__5B41514C245D2873");

            entity.Property(e => e.VentaId).HasColumnName("VentaID");
            entity.Property(e => e.FechaVenta).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Venta)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_Ventas_Usuarios");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
