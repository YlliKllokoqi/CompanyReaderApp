using CompanyReader.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyReader.Domain.Repository.Interfaces
{
    public interface ICompanyRepository
    {
        void CreateCompanyRecord(Company company);
    }
}
