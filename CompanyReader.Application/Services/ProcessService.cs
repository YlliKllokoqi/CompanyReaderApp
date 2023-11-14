using CompanyReader.Application.Dtos;
using CsvHelper;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace CompanyReader.Application.Services
{
    public class ProcessService : IProcessService
    {
        public List<CompanyDto> ProcessCsv(IFormFile file)
        {
            List<CompanyDto> companyDtos = new List<CompanyDto>();

            using (var reader = new StreamReader(file.OpenReadStream()))
            using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                companyDtos = csv.GetRecords<CompanyDto>().ToList();
            }

            return companyDtos;
        }
    }
}
