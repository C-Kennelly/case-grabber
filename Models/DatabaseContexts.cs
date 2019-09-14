using Microsoft.EntityFrameworkCore;
using System;

namespace case_grabber.Models
{
    public class CaseLawContext : DbContext
    {
        public DbSet<Item> Items {get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("CASELAW_DBSTRING"));
        }
    }

}