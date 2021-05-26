using Microsoft.EntityFrameworkCore;
using System;
namespace Flix
{
    public class SerieContext : DbContext
    {
        public DbSet<Serie> Serie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\dio\cadastro-series-dotnet\seriesDB.db");
    }
}