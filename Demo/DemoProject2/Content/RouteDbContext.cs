using DemoProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject2.Content
{
    internal class RouteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseSqlServer("Server = DESKTOP-K2FJ8AV ; Database = Route03 ; Trusted_Connection = true ; trustservercertificate = true");
    }
    public DbSet<FullTimeEmployee> FullTimeEmployees {  get; set; }
    public DbSet<PartTimeEmployee> PartTimeEmployees {  get; set; }
}
