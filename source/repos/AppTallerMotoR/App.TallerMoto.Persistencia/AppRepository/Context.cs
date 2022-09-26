using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using App.TallerMoto.Dominio.Entidades;

namespace App.TallerMoto.Persistencia.AppRepository
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<DetalleMantenimiento> DetalleMantenimientos { get; set; }
        public virtual DbSet<DetalleXrepuesto> DetalleXrepuestos { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<IngresoVehiculo> IngresoVehiculos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Repuesto> Repuestos { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__A3C02A1045386046");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetalleMantenimiento>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PK__DetalleM__E43646A565230A5F");

                entity.ToTable("DetalleMantenimiento");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdIngresoNavigation)
                    .WithMany(p => p.DetalleMantenimientos)
                    .HasForeignKey(d => d.IdIngreso)
                    .HasConstraintName("FK_DetalleMantenimiento_IngresoVehiculo");
            });

            modelBuilder.Entity<DetalleXrepuesto>(entity =>
            {
                entity.HasKey(e => e.IdDetalleXrepuesto)
                    .HasName("PK__DetalleX__AFD4312DEFBA73BD");

                entity.ToTable("DetalleXRepuesto");

                entity.Property(e => e.IdDetalleXrepuesto).HasColumnName("IdDetalleXRepuesto");

                entity.Property(e => e.Placa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDetalleNavigation)
                    .WithMany(p => p.DetalleXrepuestos)
                    .HasForeignKey(d => d.IdDetalle)
                    .HasConstraintName("FK__DetalleXR__IdDet__37A5467C");

                entity.HasOne(d => d.IdRepuestoNavigation)
                    .WithMany(p => p.DetalleXrepuestos)
                    .HasForeignKey(d => d.IdRepuesto)
                    .HasConstraintName("FK__DetalleXR__IdRep__38996AB5");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__Estado__FBB0EDC156E8DB40");

                entity.ToTable("Estado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IngresoVehiculo>(entity =>
            {
                entity.HasKey(e => e.IdIngreso)
                    .HasName("PK__IngresoV__901EF2E3D17D2BE2");

                entity.ToTable("IngresoVehiculo");

                entity.Property(e => e.Descripicion)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.Placa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVehiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMecanicoNavigation)
                    .WithMany(p => p.IngresoVehiculoIdMecanicoNavigations)
                    .HasForeignKey(d => d.IdMecanico)
                    .HasConstraintName("FK__IngresoVe__IdMec__2E1BDC42");

                entity.HasOne(d => d.IdRecepcionistaNavigation)
                    .WithMany(p => p.IngresoVehiculoIdRecepcionistaNavigations)
                    .HasForeignKey(d => d.IdRecepcionista)
                    .HasConstraintName("FK__IngresoVe__IdRec__2C3393D0");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.IngresoVehiculoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__IngresoVe__IdUsu__2D27B809");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Personas__2EC8D2ACCB282472");

                entity.ToTable("Persona");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__Personas__IdRol__267ABA7A");
            });

            modelBuilder.Entity<Repuesto>(entity =>
            {
                entity.HasKey(e => e.IdRepuesto)
                    .HasName("PK__Repuesto__318BBE67D2F351B4");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Repuestos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Repuestos__IdCat__34C8D9D1");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Rol__2A49584C42C2DF0D");

                entity.ToTable("Rol");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97BA3AF97D");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Usuario");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK__Usuario__IdPerso__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

