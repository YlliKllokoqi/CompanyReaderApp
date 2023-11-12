using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions.interfaces
{
    public interface ICompanyService
    {
        Task<CompanyDto> CreateAsync(ComapnyCreationDto comapnyCreationDto, CancellationToken cancellationToken = default);
    }
}
