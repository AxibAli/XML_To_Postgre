using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AppDbContext:DbContext
    {
        private readonly string connectionString;
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(
                @"Server=john.db.elephantsql.com;Database=okotdvdf;User Id=okotdvdf;Password=a41gf_wI2EliE3TYFVCSqAdCWL4sxMCq;Port=5432"
            );
        }

        public DbSet<Airport_Datalist> airport_Datalists { get; set; }
        public DbSet<Weight_Header> weight_Headers { get; set; }
    }
}
