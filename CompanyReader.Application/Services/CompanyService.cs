using AutoMapper;
using CompanyReader.Application.Dtos;
using CompanyReader.Domain.Entities;
using CompanyReader.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyReader.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository repository;
        private readonly IMapper mapper;

        public CompanyService(ICompanyRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void CreateRecord(CompanyDto companyDto)
        {
            var createdRecord = mapper.Map<Company>(companyDto);
            repository.CreateCompanyRecord(createdRecord);
        }
    }
}
