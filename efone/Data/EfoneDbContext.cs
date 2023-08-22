using efone.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace efone.Data
{
    public class EfoneDbContext : DbContext
    {
        public EfoneDbContext(DbContextOptions<EfoneDbContext> options) :base(options)
        {

        }

        public DbSet<Contacts> Contacts { get; set; }
    }
}
