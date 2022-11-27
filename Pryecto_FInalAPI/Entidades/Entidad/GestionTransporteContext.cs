using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entidades.Entidad
{
    public partial class GestionTransporteContext : DbContext
    {
        public GestionTransporteContext()
        {
        }

        public GestionTransporteContext(DbContextOptions<GestionTransporteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Choferes> Choferes { get; set; }
        public virtual DbSet<PerfilAsignado> PerfilAsignado { get; set; }
        public virtual DbSet<Ruta> Ruta { get; set; }
        public virtual DbSet<RutaChofer> RutaChofer { get; set; }
        public virtual DbSet<UnidadAsignada> UnidadAsignada { get; set; }
        public virtual DbSet<Unidades> Unidades { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ASU;Initial Catalog=GestionTransporte;Persist Security info=true;user id=user_uam; password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Choferes>(entity =>
            {
                entity.HasKey(e => e.CodEmpleado);

                entity.Property(e => e.CodEmpleado)
                    .HasColumnName("Cod_Empleado")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExpLicencia)
                    .HasColumnName("Exp_Licencia")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PerfilAsignado>(entity =>
            {
                entity.HasKey(e => e.Perfil);

                entity.Property(e => e.Perfil).ValueGeneratedNever();

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ruta>(entity =>
            {
                entity.HasKey(e => new { e.NombreRuta, e.MontoPasaje });

                entity.Property(e => e.NombreRuta)
                    .HasColumnName("Nombre_Ruta")
                    .HasMaxLength(50);

                entity.Property(e => e.MontoPasaje).HasColumnName("Monto_Pasaje");

                entity.Property(e => e.CantidadParadas).HasColumnName("Cantidad_Paradas");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RutaChofer>(entity =>
            {
                entity.HasKey(e => new { e.NombreRuta, e.MontoPasaje, e.CodEmpleado });

                entity.Property(e => e.NombreRuta)
                    .HasColumnName("Nombre_Ruta")
                    .HasMaxLength(50);

                entity.Property(e => e.MontoPasaje).HasColumnName("Monto_Pasaje");

                entity.Property(e => e.CodEmpleado).HasColumnName("Cod_Empleado");

                entity.Property(e => e.CantidadPasajeros).HasColumnName("Cantidad_Pasajeros");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.CodEmpleadoNavigation)
                    .WithMany(p => p.RutaChofer)
                    .HasForeignKey(d => d.CodEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RutaChofer_Choferes");

                entity.HasOne(d => d.Ruta)
                    .WithMany(p => p.RutaChofer)
                    .HasForeignKey(d => new { d.NombreRuta, d.MontoPasaje })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RutaChofer_Ruta");
            });

            modelBuilder.Entity<UnidadAsignada>(entity =>
            {
                entity.Property(e => e.CodEmpleado).HasColumnName("Cod_Empleado");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CodEmpleadoNavigation)
                    .WithMany(p => p.UnidadAsignada)
                    .HasForeignKey(d => d.CodEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnidadAsignada_Choferes");

                entity.HasOne(d => d.PlacaNavigation)
                    .WithMany(p => p.UnidadAsignada)
                    .HasForeignKey(d => d.Placa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnidadAsignada_Unidades");
            });

            modelBuilder.Entity<Unidades>(entity =>
            {
                entity.HasKey(e => e.Placa);

                entity.Property(e => e.Placa)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Cedula);

                entity.Property(e => e.Cedula).ValueGeneratedNever();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PerfilNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.Perfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_PerfilAsignado");
            });
        }
    }
}
