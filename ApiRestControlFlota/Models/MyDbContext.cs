using Microsoft.EntityFrameworkCore;

namespace ApiRestControlFlota.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>options):base(options)
        { 
        
        }

        public DbSet<Vehiculo>Vehiculos { get; set; }
        public DbSet<Conductor> Conductores { get; set; }
        public DbSet<Viajes> Viajes { get; set; }
        public DbSet<GastoPorVehiculo> GastoPorVehiculos { get; set; }
    }
}
