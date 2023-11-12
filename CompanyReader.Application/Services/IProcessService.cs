using CompanyReader.Application.Dtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyReader.Application.Services
{
    public interface IProcessService
    {
        List<CompanyDto> ProcessCsv(IFormFile file);
    }
}
