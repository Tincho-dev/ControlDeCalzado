using System;
using Microsoft.AspNet.Identity.EntityFramework;
using Model;
using System.Data.Entity;
using Model.Domain.ControlDeCalzado;
using Model.Domain;
using System.Linq;

namespace Persistanse
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRol> ApplicationRole { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; }

        public DbSet<Alerta> Alertas { get; set; }
        public DbSet<Color> Colores { get; set; }
        public DbSet<Defecto> Defectos { get; set; }
        public DbSet<HorarioDeControl> HorariosDeControl { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }
        public DbSet<JornadaLaboral> JornadasLaborales { get; set; }
        public DbSet<LineaDeProduccion> LineasDeProduccion { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<OrdenDeProduccion> OrdenesDeProduccion { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public static ApplicationDbContext Create()
        {

            var db = new ApplicationDbContext();

            if(!db.ApplicationRole.Any())
            {
                db.ApplicationRole.Add(new ApplicationRol { Name = "Admin" });
                db.ApplicationRole.Add(new ApplicationRol { Name = "SuperLinea" });
                db.ApplicationRole.Add(new ApplicationRol { Name = "SuperCalidad" });
            }

            return db;
        }
    }
}
