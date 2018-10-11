using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoDefinitivo.Models
{
    public partial class proyectoDefContext : DbContext
    {
        public proyectoDefContext()
        {
        }

        public proyectoDefContext(DbContextOptions<proyectoDefContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<MovimientoCuenta> MovimientoCuenta { get; set; }
        public virtual DbSet<MovimientoPrestamo> MovimientoPrestamo { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }
        public virtual DbSet<TipoMovimiento> TipoMovimiento { get; set; }
        public virtual DbSet<TipoPrestamo> TipoPrestamo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-EGE8HAQ;Database=proyectoDef;User Id=sa;Password=sofi; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.HasKey(e => e.IdCuenta);

                entity.Property(e => e.IdCuenta)
                    .HasColumnName("idCuenta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Disponible)
                    .HasColumnName("disponible")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IdTipoCuenta).HasColumnName("idTipoCuenta");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NumeroCuenta)
                    .IsRequired()
                    .HasColumnName("numeroCuenta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Saldo)
                    .HasColumnName("saldo")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdTipoCuentaNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.IdTipoCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuenta_TipoCuenta");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuenta_Usuario");
            });

            modelBuilder.Entity<MovimientoCuenta>(entity =>
            {
                entity.HasKey(e => e.IdMovimientoCuenta);

                entity.Property(e => e.IdMovimientoCuenta)
                    .HasColumnName("idMovimientoCuenta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdTipoMovimiento).HasColumnName("idTipoMovimiento");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasColumnName("numeroDocumento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.MovimientoCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovimientoCuenta_Cuenta");

                entity.HasOne(d => d.IdTipoMovimientoNavigation)
                    .WithMany(p => p.MovimientoCuenta)
                    .HasForeignKey(d => d.IdTipoMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovimientoCuenta_TipoMovimiento");
            });

            modelBuilder.Entity<MovimientoPrestamo>(entity =>
            {
                entity.HasKey(e => e.IdMovimientoPrestamo);

                entity.Property(e => e.IdMovimientoPrestamo)
                    .HasColumnName("idMovimientoPrestamo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Capital)
                    .HasColumnName("capital")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Cuota)
                    .HasColumnName("cuota")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPrestamo).HasColumnName("idPrestamo");

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("numDocumento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.HasKey(e => e.IdPrestamo);

                entity.Property(e => e.IdPrestamo)
                    .HasColumnName("idPrestamo")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdTipoPrestamo).HasColumnName("idTipoPrestamo");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasColumnName("moneda")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Saldo)
                    .HasColumnName("saldo")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorDia)
                    .HasColumnName("valorDia")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdTipoPrestamoNavigation)
                    .WithMany(p => p.Prestamo)
                    .HasForeignKey(d => d.IdTipoPrestamo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestamo_TipoPrestamo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Prestamo)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestamo_Usuario");
            });

            modelBuilder.Entity<TipoCuenta>(entity =>
            {
                entity.HasKey(e => e.IdTipoCuenta);

                entity.Property(e => e.IdTipoCuenta)
                    .HasColumnName("idTipoCuenta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoMovimiento>(entity =>
            {
                entity.HasKey(e => e.IdTipoMovimiento);

                entity.Property(e => e.IdTipoMovimiento)
                    .HasColumnName("idTipoMovimiento")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPrestamo>(entity =>
            {
                entity.HasKey(e => e.IdTipoPrestamo);

                entity.Property(e => e.IdTipoPrestamo)
                    .HasColumnName("idTipoPrestamo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("idUsuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .HasColumnName("apellidos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .HasColumnName("nombreUsuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
