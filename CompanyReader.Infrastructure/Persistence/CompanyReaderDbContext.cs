using CompanyReader.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CompanyReader.Infrastructure.Persistence
{
    public class CompanyReaderDbContext : DbContext
    {
        public CompanyReaderDbContext()
        {

        }

        public CompanyReaderDbContext(DbContextOptions<CompanyReaderDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Ylli\\SQLEXPRESS;Database=CompanyReaderDb;Integrated Security=True;Encrypt=False;");
        }


    }
}
