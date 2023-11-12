using CompanyReader.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyReader.Application.Services
{
    public interface ICompanyService
    {
        void CreateRecord(CompanyDto companyDto);
    }
}
