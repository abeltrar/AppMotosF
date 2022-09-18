using Microsoft.EntityFrameworkCore;
using System;
using TallerMoto.App.Dominio.Entidades;


namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class AppContext:DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetalleMantenimiento> DetalleMantenimientos { get; set; }
        public DbSet<DetalleXRepuesto> detalleXRepuestos { get; set; }
        public DbSet<IngresoVehiculo> IngresoVehiculos { get; set; }
        public DbSet<Repuestos> repuestos { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Estado> estado { get; set; }

    }
}
