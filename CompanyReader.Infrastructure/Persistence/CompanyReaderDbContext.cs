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
            optionsBuilder.UseInMemoryDatabase("companyReaderdb");

        }


    }
}
