using CompanyReader.Domain.Entities;
using CompanyReader.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyReader.Infrastructure.Persistence.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CompanyReaderDbContext dbContext;

        public CompanyRepository(CompanyReaderDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateCompanyRecord(Company company)
        {
            dbContext.Add(company);
            dbContext.SaveChanges();
        }
    }
}
