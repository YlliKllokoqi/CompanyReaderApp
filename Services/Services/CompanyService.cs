using AutoMapper;
using Contracts.Dtos;
using Domain.Entities;
using Domain.Repositories;
using Services.Abstractions.interfaces;

namespace Services.Services
{
    internal sealed class CompanyService : ICompanyService
    {
        private readonly IRepositoryManager repositoryManager;

        public async Task<CompanyDto> CreateAsync(CompanyDto companyCreationDto, CancellationToken cancellationToken = default)
        {
            var company = Mapper.Map<Company>(companyCreationDto);

            repositoryManager.CompanyRepository.Insert(company);

            await repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Mapper.Map<CompanyDto>(company);
        }

    }
}
