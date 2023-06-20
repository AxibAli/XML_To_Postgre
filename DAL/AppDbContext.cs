using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Domain;

namespace DAL
{
    public class AppDbContext:DbContext
    {
        private readonly string connectionString;
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=XMLData;User Id=postgres;Password=abc1234;");
        }

        public DbSet<Airport_Datalist> airport_Datalists { get; set; }
        public DbSet<Weight_Header> weight_Headers { get; set; }
    }
}
